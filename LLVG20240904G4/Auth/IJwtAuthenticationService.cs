﻿namespace LLVG20240904G4.Auth
{
    public interface IJwtAuthenticationService
    {
        String Authenticate(string userName);
    }
}