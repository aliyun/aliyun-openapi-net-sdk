/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class GetFeeResponseUnmarshaller
    {
        public static GetFeeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFeeResponse getFeeResponse = new GetFeeResponse();

			getFeeResponse.HttpResponse = _ctx.HttpResponse;
			getFeeResponse.AcctgPeriod = _ctx.StringValue("GetFee.AcctgPeriod");
			getFeeResponse.BaseTotalAmount = _ctx.StringValue("GetFee.BaseTotalAmount");
			getFeeResponse.BaseTotalAmountWithoutTax = _ctx.StringValue("GetFee.BaseTotalAmountWithoutTax");
			getFeeResponse.BaseTotalTax = _ctx.StringValue("GetFee.BaseTotalTax");
			getFeeResponse.CreatedStamp = _ctx.LongValue("GetFee.CreatedStamp");
			getFeeResponse.Id = _ctx.LongValue("GetFee.Id");
			getFeeResponse.RequestId = _ctx.StringValue("GetFee.RequestId");
			getFeeResponse.Url = _ctx.StringValue("GetFee.Url");
			getFeeResponse.Payer = _ctx.StringValue("GetFee.Payer");
			getFeeResponse.CanUpdate = _ctx.BooleanValue("GetFee.CanUpdate");
			getFeeResponse.LabelData = _ctx.StringValue("GetFee.LabelData");

			GetFeeResponse.GetFee_FeeTypeEnum feeTypeEnum = new GetFeeResponse.GetFee_FeeTypeEnum();
			feeTypeEnum.Label = _ctx.StringValue("GetFee.FeeTypeEnum.Label");
			feeTypeEnum._Value = _ctx.StringValue("GetFee.FeeTypeEnum.Value");
			getFeeResponse.FeeTypeEnum = feeTypeEnum;

			GetFeeResponse.GetFee_Kind kind = new GetFeeResponse.GetFee_Kind();
			kind.Key = _ctx.StringValue("GetFee.Kind.Key");
			kind._Value = _ctx.StringValue("GetFee.Kind.Value");
			getFeeResponse.Kind = kind;

			GetFeeResponse.GetFee_PayMethod payMethod = new GetFeeResponse.GetFee_PayMethod();
			payMethod.Key = _ctx.StringValue("GetFee.PayMethod.Key");
			payMethod._Value = _ctx.StringValue("GetFee.PayMethod.Value");
			getFeeResponse.PayMethod = payMethod;

			GetFeeResponse.GetFee_Use use = new GetFeeResponse.GetFee_Use();
			use.Key = _ctx.StringValue("GetFee.Use.Key");
			use._Value = _ctx.StringValue("GetFee.Use.Value");
			getFeeResponse.Use = use;

			List<GetFeeResponse.GetFee_AcctgTransList> getFeeResponse_voucherTransList = new List<GetFeeResponse.GetFee_AcctgTransList>();
			for (int i = 0; i < _ctx.Length("GetFee.VoucherTransList.Length"); i++) {
				GetFeeResponse.GetFee_AcctgTransList acctgTransList = new GetFeeResponse.GetFee_AcctgTransList();

				GetFeeResponse.GetFee_AcctgTransList.GetFee_VoucherTransId voucherTransId = new GetFeeResponse.GetFee_AcctgTransList.GetFee_VoucherTransId();
				voucherTransId.Id = _ctx.LongValue("GetFee.VoucherTransList["+ i +"].VoucherTransId.Id");
				voucherTransId.RefVoucherIds = _ctx.StringValue("GetFee.VoucherTransList["+ i +"].VoucherTransId.RefVoucherIds");
				acctgTransList.VoucherTransId = voucherTransId;

				getFeeResponse_voucherTransList.Add(acctgTransList);
			}
			getFeeResponse.VoucherTransList = getFeeResponse_voucherTransList;
        
			return getFeeResponse;
        }
    }
}
