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
        public static QueryCashCouponsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCashCouponsResponse queryCashCouponsResponse = new QueryCashCouponsResponse();

			queryCashCouponsResponse.HttpResponse = _ctx.HttpResponse;
			queryCashCouponsResponse.RequestId = _ctx.StringValue("QueryCashCoupons.RequestId");
			queryCashCouponsResponse.Success = _ctx.BooleanValue("QueryCashCoupons.Success");
			queryCashCouponsResponse.Code = _ctx.StringValue("QueryCashCoupons.Code");
			queryCashCouponsResponse.Message = _ctx.StringValue("QueryCashCoupons.Message");

			List<QueryCashCouponsResponse.QueryCashCoupons_CashCoupon> queryCashCouponsResponse_data = new List<QueryCashCouponsResponse.QueryCashCoupons_CashCoupon>();
			for (int i = 0; i < _ctx.Length("QueryCashCoupons.Data.Length"); i++) {
				QueryCashCouponsResponse.QueryCashCoupons_CashCoupon cashCoupon = new QueryCashCouponsResponse.QueryCashCoupons_CashCoupon();
				cashCoupon.CashCouponId = _ctx.LongValue("QueryCashCoupons.Data["+ i +"].CashCouponId");
				cashCoupon.CashCouponNo = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].CashCouponNo");
				cashCoupon.GrantedTime = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].GrantedTime");
				cashCoupon.EffectiveTime = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].EffectiveTime");
				cashCoupon.ExpiryTime = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].ExpiryTime");
				cashCoupon.ApplicableProducts = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].ApplicableProducts");
				cashCoupon.ApplicableScenarios = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].ApplicableScenarios");
				cashCoupon.NominalValue = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].NominalValue");
				cashCoupon.Balance = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].Balance");
				cashCoupon.Status = _ctx.StringValue("QueryCashCoupons.Data["+ i +"].Status");

				queryCashCouponsResponse_data.Add(cashCoupon);
			}
			queryCashCouponsResponse.Data = queryCashCouponsResponse_data;
        
			return queryCashCouponsResponse;
        }
    }
}
