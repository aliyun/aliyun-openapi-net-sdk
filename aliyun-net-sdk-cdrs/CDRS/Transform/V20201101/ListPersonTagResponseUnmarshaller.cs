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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListPersonTagResponseUnmarshaller
    {
        public static ListPersonTagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersonTagResponse listPersonTagResponse = new ListPersonTagResponse();

			listPersonTagResponse.HttpResponse = _ctx.HttpResponse;
			listPersonTagResponse.Code = _ctx.StringValue("ListPersonTag.Code");
			listPersonTagResponse.Message = _ctx.StringValue("ListPersonTag.Message");
			listPersonTagResponse.RequestId = _ctx.StringValue("ListPersonTag.RequestId");
			listPersonTagResponse.PageNumber = _ctx.LongValue("ListPersonTag.PageNumber");
			listPersonTagResponse.PageSize = _ctx.LongValue("ListPersonTag.PageSize");
			listPersonTagResponse.TotalCount = _ctx.LongValue("ListPersonTag.TotalCount");

			List<ListPersonTagResponse.ListPersonTag_Datas> listPersonTagResponse_data = new List<ListPersonTagResponse.ListPersonTag_Datas>();
			for (int i = 0; i < _ctx.Length("ListPersonTag.Data.Length"); i++) {
				ListPersonTagResponse.ListPersonTag_Datas datas = new ListPersonTagResponse.ListPersonTag_Datas();
				datas.CorpId = _ctx.StringValue("ListPersonTag.Data["+ i +"].CorpId");
				datas.TagValue = _ctx.StringValue("ListPersonTag.Data["+ i +"].TagValue");
				datas._Value = _ctx.StringValue("ListPersonTag.Data["+ i +"].Value");

				listPersonTagResponse_data.Add(datas);
			}
			listPersonTagResponse.Data = listPersonTagResponse_data;
        
			return listPersonTagResponse;
        }
    }
}
