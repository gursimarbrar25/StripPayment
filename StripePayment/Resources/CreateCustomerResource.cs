﻿using StripePayment.Resources;

 public record CreateCustomerResource(
    string Email,
    string Name,
    CreateCardResource Card);


