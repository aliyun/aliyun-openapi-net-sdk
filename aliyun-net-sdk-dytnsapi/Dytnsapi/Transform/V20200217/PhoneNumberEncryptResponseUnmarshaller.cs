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
    public class PhoneNumberEncryptResponseUnmarshaller
    {
        public static PhoneNumberEncryptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PhoneNumberEncryptResponse phoneNumberEncryptResponse = new PhoneNumberEncryptResponse();

			phoneNumberEncryptResponse.HttpResponse = _ctx.HttpResponse;
			phoneNumberEncryptResponse.RequestId = _ctx.StringValue("PhoneNumberEncrypt.RequestId");
			phoneNumberEncryptResponse.Code = _ctx.StringValue("PhoneNumberEncrypt.Code");
			phoneNumberEncryptResponse.Message = _ctx.StringValue("PhoneNumberEncrypt.Message");

			List<PhoneNumberEncryptResponse.PhoneNumberEncrypt_DataItem> phoneNumberEncryptResponse_data = new List<PhoneNumberEncryptResponse.PhoneNumberEncrypt_DataItem>();
			for (int i = 0; i < _ctx.Length("PhoneNumberEncrypt.Data.Length"); i++) {
				PhoneNumberEncryptResponse.PhoneNumberEncrypt_DataItem dataItem = new PhoneNumberEncryptResponse.PhoneNumberEncrypt_DataItem();
				dataItem.OriginalNumber = _ctx.StringValue("PhoneNumberEncrypt.Data["+ i +"].OriginalNumber");
				dataItem.EncryptedNumber = _ctx.StringValue("PhoneNumberEncrypt.Data["+ i +"].EncryptedNumber");
				dataItem.ExpireTime = _ctx.StringValue("PhoneNumberEncrypt.Data["+ i +"].ExpireTime");

				phoneNumberEncryptResponse_data.Add(dataItem);
			}
			phoneNumberEncryptResponse.Data = phoneNumberEncryptResponse_data;
        
			return phoneNumberEncryptResponse;
        }
    }
}
