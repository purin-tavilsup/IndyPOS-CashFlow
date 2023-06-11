﻿using FluentValidation;

namespace IndyPOS.CashFlow.Application.InventoryProducts.Queries.GetInventoryProductById;

public class GetInventoryProductByIdQueryValidator : AbstractValidator<GetInventoryProductByIdQuery>
{
	public GetInventoryProductByIdQueryValidator()
	{
		RuleFor(x => x.Id)
			.GreaterThan(0).WithMessage("Inventory Product Id is invalid.");
	}
}