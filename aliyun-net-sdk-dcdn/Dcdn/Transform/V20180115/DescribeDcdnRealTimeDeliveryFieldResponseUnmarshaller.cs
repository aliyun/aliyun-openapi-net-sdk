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
    public class DescribeDcdnRealTimeDeliveryFieldResponseUnmarshaller
    {
        public static DescribeDcdnRealTimeDeliveryFieldResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnRealTimeDeliveryFieldResponse describeDcdnRealTimeDeliveryFieldResponse = new DescribeDcdnRealTimeDeliveryFieldResponse();

			describeDcdnRealTimeDeliveryFieldResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnRealTimeDeliveryFieldResponse.RequestId = _ctx.StringValue("DescribeDcdnRealTimeDeliveryField.RequestId");

			List<DescribeDcdnRealTimeDeliveryFieldResponse.DescribeDcdnRealTimeDeliveryField_Fields> describeDcdnRealTimeDeliveryFieldResponse_content = new List<DescribeDcdnRealTimeDeliveryFieldResponse.DescribeDcdnRealTimeDeliveryField_Fields>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnRealTimeDeliveryField.Content.Length"); i++) {
				DescribeDcdnRealTimeDeliveryFieldResponse.DescribeDcdnRealTimeDeliveryField_Fields fields = new DescribeDcdnRealTimeDeliveryFieldResponse.DescribeDcdnRealTimeDeliveryField_Fields();
				fields.FieldName = _ctx.StringValue("DescribeDcdnRealTimeDeliveryField.Content["+ i +"].FieldName");
				fields.Description = _ctx.StringValue("DescribeDcdnRealTimeDeliveryField.Content["+ i +"].Description");

				describeDcdnRealTimeDeliveryFieldResponse_content.Add(fields);
			}
			describeDcdnRealTimeDeliveryFieldResponse.Content = describeDcdnRealTimeDeliveryFieldResponse_content;
        
			return describeDcdnRealTimeDeliveryFieldResponse;
        }
    }
}
