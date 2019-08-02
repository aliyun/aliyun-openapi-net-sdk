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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryCashCouponsResponseUnmarshaller
    {
        public static QueryCashCouponsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCashCouponsResponse queryCashCouponsResponse = new QueryCashCouponsResponse();

			queryCashCouponsResponse.HttpResponse = context.HttpResponse;
			queryCashCouponsResponse.RequestId = context.StringValue("QueryCashCoupons.RequestId");
			queryCashCouponsResponse.Success = context.BooleanValue("QueryCashCoupons.Success");
			queryCashCouponsResponse.Code = context.StringValue("QueryCashCoupons.Code");
			queryCashCouponsResponse.Message = context.StringValue("QueryCashCoupons.Message");

			List<QueryCashCouponsResponse.QueryCashCoupons_CashCoupon> queryCashCouponsResponse_data = new List<QueryCashCouponsResponse.QueryCashCoupons_CashCoupon>();
			for (int i = 0; i < context.Length("QueryCashCoupons.Data.Length"); i++) {
				QueryCashCouponsResponse.QueryCashCoupons_CashCoupon cashCoupon = new QueryCashCouponsResponse.QueryCashCoupons_CashCoupon();
				cashCoupon.CashCouponId = context.LongValue("QueryCashCoupons.Data["+ i +"].CashCouponId");
				cashCoupon.CashCouponNo = context.StringValue("QueryCashCoupons.Data["+ i +"].CashCouponNo");
				cashCoupon.GrantedTime = context.StringValue("QueryCashCoupons.Data["+ i +"].GrantedTime");
				cashCoupon.EffectiveTime = context.StringValue("QueryCashCoupons.Data["+ i +"].EffectiveTime");
				cashCoupon.ExpiryTime = context.StringValue("QueryCashCoupons.Data["+ i +"].ExpiryTime");
				cashCoupon.ApplicableProducts = context.StringValue("QueryCashCoupons.Data["+ i +"].ApplicableProducts");
				cashCoupon.ApplicableScenarios = context.StringValue("QueryCashCoupons.Data["+ i +"].ApplicableScenarios");
				cashCoupon.NominalValue = context.StringValue("QueryCashCoupons.Data["+ i +"].NominalValue");
				cashCoupon.Balance = context.StringValue("QueryCashCoupons.Data["+ i +"].Balance");
				cashCoupon.Status = context.StringValue("QueryCashCoupons.Data["+ i +"].Status");

				queryCashCouponsResponse_data.Add(cashCoupon);
			}
			queryCashCouponsResponse.Data = queryCashCouponsResponse_data;
        
			return queryCashCouponsResponse;
        }
    }
}
