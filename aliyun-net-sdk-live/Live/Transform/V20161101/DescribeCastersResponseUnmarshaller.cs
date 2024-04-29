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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCastersResponseUnmarshaller
    {
        public static DescribeCastersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCastersResponse describeCastersResponse = new DescribeCastersResponse();

			describeCastersResponse.HttpResponse = _ctx.HttpResponse;
			describeCastersResponse.RequestId = _ctx.StringValue("DescribeCasters.RequestId");
			describeCastersResponse.Total = _ctx.IntegerValue("DescribeCasters.Total");

			List<DescribeCastersResponse.DescribeCasters_Caster> describeCastersResponse_casterList = new List<DescribeCastersResponse.DescribeCasters_Caster>();
			for (int i = 0; i < _ctx.Length("DescribeCasters.CasterList.Length"); i++) {
				DescribeCastersResponse.DescribeCasters_Caster caster = new DescribeCastersResponse.DescribeCasters_Caster();
				caster.CasterId = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].CasterId");
				caster.CasterName = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].CasterName");
				caster.CasterTemplate = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].CasterTemplate");
				caster.ChannelEnable = _ctx.IntegerValue("DescribeCasters.CasterList["+ i +"].ChannelEnable");
				caster.ChargeType = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].ChargeType");
				caster.CreateTime = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].CreateTime");
				caster.Duration = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].Duration");
				caster.ExpireTime = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].ExpireTime");
				caster.LastModified = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].LastModified");
				caster.NormType = _ctx.IntegerValue("DescribeCasters.CasterList["+ i +"].NormType");
				caster.PurchaseTime = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].PurchaseTime");
				caster.RoomId = _ctx.IntegerValue("DescribeCasters.CasterList["+ i +"].RoomId");
				caster.StartTime = _ctx.StringValue("DescribeCasters.CasterList["+ i +"].StartTime");
				caster.Status = _ctx.IntegerValue("DescribeCasters.CasterList["+ i +"].Status");

				describeCastersResponse_casterList.Add(caster);
			}
			describeCastersResponse.CasterList = describeCastersResponse_casterList;
        
			return describeCastersResponse;
        }
    }
}
