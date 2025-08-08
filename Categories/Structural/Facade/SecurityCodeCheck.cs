  public class SecurityCodeCheck
  {
      private readonly int _securityCode = 1234;

      public bool IsValidCode(int securityCode)
      {
          return securityCode == _securityCode;
      }
  }