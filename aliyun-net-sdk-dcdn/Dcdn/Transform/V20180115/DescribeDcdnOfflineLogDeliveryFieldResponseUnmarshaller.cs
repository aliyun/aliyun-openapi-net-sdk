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
    public class DescribeDcdnOfflineLogDeliveryFieldResponseUnmarshaller
    {
        public static DescribeDcdnOfflineLogDeliveryFieldResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnOfflineLogDeliveryFieldResponse describeDcdnOfflineLogDeliveryFieldResponse = new DescribeDcdnOfflineLogDeliveryFieldResponse();

			describeDcdnOfflineLogDeliveryFieldResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnOfflineLogDeliveryFieldResponse.RequestId = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryField.RequestId");

			List<DescribeDcdnOfflineLogDeliveryFieldResponse.DescribeDcdnOfflineLogDeliveryField_Field> describeDcdnOfflineLogDeliveryFieldResponse_fields = new List<DescribeDcdnOfflineLogDeliveryFieldResponse.DescribeDcdnOfflineLogDeliveryField_Field>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnOfflineLogDeliveryField.Fields.Length"); i++) {
				DescribeDcdnOfflineLogDeliveryFieldResponse.DescribeDcdnOfflineLogDeliveryField_Field field = new DescribeDcdnOfflineLogDeliveryFieldResponse.DescribeDcdnOfflineLogDeliveryField_Field();
				field.FieldId = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryField.Fields["+ i +"].FieldId");
				field.FieldName = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryField.Fields["+ i +"].FieldName");
				field.Description = _ctx.StringValue("DescribeDcdnOfflineLogDeliveryField.Fields["+ i +"].Description");

				describeDcdnOfflineLogDeliveryFieldResponse_fields.Add(field);
			}
			describeDcdnOfflineLogDeliveryFieldResponse.Fields = describeDcdnOfflineLogDeliveryFieldResponse_fields;
        
			return describeDcdnOfflineLogDeliveryFieldResponse;
        }
    }
}
