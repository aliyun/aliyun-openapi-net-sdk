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
using Aliyun.Acs.Dytnsapi.Model.V20200217;

namespace Aliyun.Acs.Dytnsapi.Transform.V20200217
{
    public class TwoElementsVerificationResponseUnmarshaller
    {
        public static TwoElementsVerificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TwoElementsVerificationResponse twoElementsVerificationResponse = new TwoElementsVerificationResponse();

			twoElementsVerificationResponse.HttpResponse = _ctx.HttpResponse;
			twoElementsVerificationResponse.Code = _ctx.StringValue("TwoElementsVerification.Code");
			twoElementsVerificationResponse.Message = _ctx.StringValue("TwoElementsVerification.Message");
			twoElementsVerificationResponse.RequestId = _ctx.StringValue("TwoElementsVerification.RequestId");

			List<TwoElementsVerificationResponse.TwoElementsVerification_DataItem> twoElementsVerificationResponse_data = new List<TwoElementsVerificationResponse.TwoElementsVerification_DataItem>();
			for (int i = 0; i < _ctx.Length("TwoElementsVerification.Data.Length"); i++) {
				TwoElementsVerificationResponse.TwoElementsVerification_DataItem dataItem = new TwoElementsVerificationResponse.TwoElementsVerification_DataItem();
				dataItem.IsConsistent = _ctx.IntegerValue("TwoElementsVerification.Data["+ i +"].IsConsistent");
				dataItem.BasicCarrier = _ctx.StringValue("TwoElementsVerification.Data["+ i +"].BasicCarrier");

				twoElementsVerificationResponse_data.Add(dataItem);
			}
			twoElementsVerificationResponse.Data = twoElementsVerificationResponse_data;
        
			return twoElementsVerificationResponse;
        }
    }
}
