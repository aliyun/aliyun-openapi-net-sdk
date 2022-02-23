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
using Aliyun.Acs.Cloudauth_console.Model.V20190403;

namespace Aliyun.Acs.Cloudauth_console.Transform.V20190403
{
    public class RetrieveFaceResponseUnmarshaller
    {
        public static RetrieveFaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RetrieveFaceResponse retrieveFaceResponse = new RetrieveFaceResponse();

			retrieveFaceResponse.HttpResponse = _ctx.HttpResponse;
			retrieveFaceResponse.RequestId = _ctx.StringValue("RetrieveFace.RequestId");
			retrieveFaceResponse.Success = _ctx.BooleanValue("RetrieveFace.Success");

			List<RetrieveFaceResponse.RetrieveFace_DataItem> retrieveFaceResponse_data = new List<RetrieveFaceResponse.RetrieveFace_DataItem>();
			for (int i = 0; i < _ctx.Length("RetrieveFace.Data.Length"); i++) {
				RetrieveFaceResponse.RetrieveFace_DataItem dataItem = new RetrieveFaceResponse.RetrieveFace_DataItem();
				dataItem.UserId = _ctx.LongValue("RetrieveFace.Data["+ i +"].UserId");
				dataItem.UserName = _ctx.StringValue("RetrieveFace.Data["+ i +"].UserName");
				dataItem.Rate = _ctx.StringValue("RetrieveFace.Data["+ i +"].Rate");

				retrieveFaceResponse_data.Add(dataItem);
			}
			retrieveFaceResponse.Data = retrieveFaceResponse_data;
        
			return retrieveFaceResponse;
        }
    }
}
