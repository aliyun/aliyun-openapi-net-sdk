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
    public class InvalidPhoneNumberFilterResponseUnmarshaller
    {
        public static InvalidPhoneNumberFilterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InvalidPhoneNumberFilterResponse invalidPhoneNumberFilterResponse = new InvalidPhoneNumberFilterResponse();

			invalidPhoneNumberFilterResponse.HttpResponse = _ctx.HttpResponse;
			invalidPhoneNumberFilterResponse.RequestId = _ctx.StringValue("InvalidPhoneNumberFilter.RequestId");
			invalidPhoneNumberFilterResponse.Code = _ctx.StringValue("InvalidPhoneNumberFilter.Code");
			invalidPhoneNumberFilterResponse.Message = _ctx.StringValue("InvalidPhoneNumberFilter.Message");

			List<InvalidPhoneNumberFilterResponse.InvalidPhoneNumberFilter_DataItem> invalidPhoneNumberFilterResponse_data = new List<InvalidPhoneNumberFilterResponse.InvalidPhoneNumberFilter_DataItem>();
			for (int i = 0; i < _ctx.Length("InvalidPhoneNumberFilter.Data.Length"); i++) {
				InvalidPhoneNumberFilterResponse.InvalidPhoneNumberFilter_DataItem dataItem = new InvalidPhoneNumberFilterResponse.InvalidPhoneNumberFilter_DataItem();
				dataItem.Code = _ctx.StringValue("InvalidPhoneNumberFilter.Data["+ i +"].Code");
				dataItem.OriginalNumber = _ctx.StringValue("InvalidPhoneNumberFilter.Data["+ i +"].OriginalNumber");
				dataItem.EncryptedNumber = _ctx.StringValue("InvalidPhoneNumberFilter.Data["+ i +"].EncryptedNumber");
				dataItem.ExpireTime = _ctx.StringValue("InvalidPhoneNumberFilter.Data["+ i +"].ExpireTime");

				invalidPhoneNumberFilterResponse_data.Add(dataItem);
			}
			invalidPhoneNumberFilterResponse.Data = invalidPhoneNumberFilterResponse_data;
        
			return invalidPhoneNumberFilterResponse;
        }
    }
}
