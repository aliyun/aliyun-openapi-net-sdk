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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnUserRealTimeDeliveryFieldResponseUnmarshaller
    {
        public static DescribeDcdnUserRealTimeDeliveryFieldResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnUserRealTimeDeliveryFieldResponse describeDcdnUserRealTimeDeliveryFieldResponse = new DescribeDcdnUserRealTimeDeliveryFieldResponse();

			describeDcdnUserRealTimeDeliveryFieldResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnUserRealTimeDeliveryFieldResponse.RequestId = _ctx.StringValue("DescribeDcdnUserRealTimeDeliveryField.RequestId");

			List<DescribeDcdnUserRealTimeDeliveryFieldResponse.DescribeDcdnUserRealTimeDeliveryField_Fields> describeDcdnUserRealTimeDeliveryFieldResponse_content = new List<DescribeDcdnUserRealTimeDeliveryFieldResponse.DescribeDcdnUserRealTimeDeliveryField_Fields>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnUserRealTimeDeliveryField.Content.Length"); i++) {
				DescribeDcdnUserRealTimeDeliveryFieldResponse.DescribeDcdnUserRealTimeDeliveryField_Fields fields = new DescribeDcdnUserRealTimeDeliveryFieldResponse.DescribeDcdnUserRealTimeDeliveryField_Fields();
				fields.FieldName = _ctx.StringValue("DescribeDcdnUserRealTimeDeliveryField.Content["+ i +"].FieldName");
				fields.Description = _ctx.StringValue("DescribeDcdnUserRealTimeDeliveryField.Content["+ i +"].Description");
				fields.Selected = _ctx.BooleanValue("DescribeDcdnUserRealTimeDeliveryField.Content["+ i +"].Selected");

				describeDcdnUserRealTimeDeliveryFieldResponse_content.Add(fields);
			}
			describeDcdnUserRealTimeDeliveryFieldResponse.Content = describeDcdnUserRealTimeDeliveryFieldResponse_content;
        
			return describeDcdnUserRealTimeDeliveryFieldResponse;
        }
    }
}
