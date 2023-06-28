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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class ListInstancePlansModificationResponseUnmarshaller
    {
        public static ListInstancePlansModificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancePlansModificationResponse listInstancePlansModificationResponse = new ListInstancePlansModificationResponse();

			listInstancePlansModificationResponse.HttpResponse = _ctx.HttpResponse;
			listInstancePlansModificationResponse.RequestId = _ctx.StringValue("ListInstancePlansModification.RequestId");

			List<ListInstancePlansModificationResponse.ListInstancePlansModification_Plan> listInstancePlansModificationResponse_plans = new List<ListInstancePlansModificationResponse.ListInstancePlansModification_Plan>();
			for (int i = 0; i < _ctx.Length("ListInstancePlansModification.Plans.Length"); i++) {
				ListInstancePlansModificationResponse.ListInstancePlansModification_Plan plan = new ListInstancePlansModificationResponse.ListInstancePlansModification_Plan();
				plan.Core = _ctx.IntegerValue("ListInstancePlansModification.Plans["+ i +"].Core");
				plan.Bandwidth = _ctx.IntegerValue("ListInstancePlansModification.Plans["+ i +"].Bandwidth");
				plan.DiskSize = _ctx.IntegerValue("ListInstancePlansModification.Plans["+ i +"].DiskSize");
				plan.Flow = _ctx.IntegerValue("ListInstancePlansModification.Plans["+ i +"].Flow");
				plan.Memory = _ctx.IntegerValue("ListInstancePlansModification.Plans["+ i +"].Memory");
				plan.PlanId = _ctx.StringValue("ListInstancePlansModification.Plans["+ i +"].PlanId");
				plan.DiskType = _ctx.StringValue("ListInstancePlansModification.Plans["+ i +"].DiskType");
				plan.OriginPrice = _ctx.DoubleValue("ListInstancePlansModification.Plans["+ i +"].OriginPrice");
				plan.Currency = _ctx.StringValue("ListInstancePlansModification.Plans["+ i +"].Currency");
				plan.SupportPlatform = _ctx.StringValue("ListInstancePlansModification.Plans["+ i +"].SupportPlatform");

				listInstancePlansModificationResponse_plans.Add(plan);
			}
			listInstancePlansModificationResponse.Plans = listInstancePlansModificationResponse_plans;
        
			return listInstancePlansModificationResponse;
        }
    }
}
