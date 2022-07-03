package com.mikroservices.customer;

public record CustomerRegistrationRequest(
        String firstName,
        String lastName,
        String email
) {
}
