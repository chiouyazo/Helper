// Read From a Registry Key

RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Example\\Keys");
string ExampleValue = key.GetValue("ExampleValue").ToString();