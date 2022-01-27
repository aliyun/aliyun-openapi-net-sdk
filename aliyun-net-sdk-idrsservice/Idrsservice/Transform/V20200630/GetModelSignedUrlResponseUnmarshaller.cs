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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetModelSignedUrlResponseUnmarshaller
    {
        public static GetModelSignedUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetModelSignedUrlResponse getModelSignedUrlResponse = new GetModelSignedUrlResponse();

			getModelSignedUrlResponse.HttpResponse = _ctx.HttpResponse;
			getModelSignedUrlResponse.Code = _ctx.StringValue("GetModelSignedUrl.Code");
			getModelSignedUrlResponse.Message = _ctx.StringValue("GetModelSignedUrl.Message");
			getModelSignedUrlResponse.RequestId = _ctx.StringValue("GetModelSignedUrl.RequestId");

			List<GetModelSignedUrlResponse.GetModelSignedUrl_DataItem> getModelSignedUrlResponse_data = new List<GetModelSignedUrlResponse.GetModelSignedUrl_DataItem>();
			for (int i = 0; i < _ctx.Length("GetModelSignedUrl.Data.Length"); i++) {
				GetModelSignedUrlResponse.GetModelSignedUrl_DataItem dataItem = new GetModelSignedUrlResponse.GetModelSignedUrl_DataItem();
				dataItem.ModelPath = _ctx.StringValue("GetModelSignedUrl.Data["+ i +"].ModelPath");
				dataItem.PublicUrl = _ctx.StringValue("GetModelSignedUrl.Data["+ i +"].PublicUrl");
				dataItem.Md5 = _ctx.StringValue("GetModelSignedUrl.Data["+ i +"].Md5");

				getModelSignedUrlResponse_data.Add(dataItem);
			}
			getModelSignedUrlResponse.Data = getModelSignedUrlResponse_data;
        
			return getModelSignedUrlResponse;
        }
    }
}
