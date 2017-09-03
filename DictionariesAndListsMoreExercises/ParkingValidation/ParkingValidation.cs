using System;
using System.Collections.Generic;
using System.Linq;
public class ParkingValidation
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var usernameLicense = new Dictionary<string, string>();

        for (int i = 1; i <= n; i++)
        {
            var input = Console.ReadLine();
            var tokens = input.Split().ToArray();
            var username = tokens[1];
            var licenseNo = string.Empty;

            if (tokens[0] == "register")
            {
                licenseNo = tokens[2];

                if (!IsAllUpper(licenseNo) && !usernameLicense.ContainsKey(username))
                {
                    Console.WriteLine("ERROR: invalid license plate {0}", licenseNo);
                }

                else if (IsAllUpper(licenseNo) && MiddleIsNumber(licenseNo) && licenseNo.Length == 8)
                {
                    if (!usernameLicense.ContainsKey(username))
                    {
                        if (!usernameLicense.ContainsValue(licenseNo))
                        {
                            usernameLicense.Add(username, licenseNo);
                            Console.WriteLine("{0} registered {1} successfully", username, licenseNo);
                        }
                        else
                        {
                            Console.WriteLine("ERROR: license plate {0} is busy", licenseNo);
                        }
                    }

                    else
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", usernameLicense[username]);
                    }
                }

                else
                {
                    Console.WriteLine("ERROR: already registered with plate number {0}", usernameLicense[username]);
                }
            }

            else if (tokens[0] == "unregister")
            {
                if (!usernameLicense.ContainsKey(username))
                {
                    Console.WriteLine("ERROR: user {0} not found", username);
                }
                else
                {
                    usernameLicense.Remove(username);
                    Console.WriteLine("user {0} unregistered successfully", username);
                }
            }
        }

        foreach (var item in usernameLicense)
        {
            Console.WriteLine("{0} => {1}", item.Key, item.Value);
        }

    }
    public static bool IsAllUpper(string licenseNumber)
    {
        bool isUpper = true;

        for (int i = 0; i < 2; i++)
        {
            if (!Char.IsUpper(licenseNumber[i]))
            {
                isUpper = false;
                break;
            }

            for (int j = licenseNumber.Length - 1; j >= licenseNumber.Length - 2; j--)
            {
                if (!Char.IsUpper(licenseNumber[j]))
                {
                    isUpper = false;
                    break;
                }
            }
        }

        return isUpper;
    }

    public static bool MiddleIsNumber(string licenseNumber)
    {
        var licenseNo = licenseNumber.Skip(2).Take(licenseNumber.Length - 4).ToArray();

        var isNumber = true;

        try
        {
            for (int i = 0; i < licenseNo.Length; i++)
            {
                int.Parse(licenseNo[i].ToString());
            }
        }
        catch (Exception)
        {
            isNumber = false;
        }

        return isNumber;
    }
}
