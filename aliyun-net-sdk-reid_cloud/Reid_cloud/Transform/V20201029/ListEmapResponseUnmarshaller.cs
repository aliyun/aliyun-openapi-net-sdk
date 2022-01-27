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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class ListEmapResponseUnmarshaller
    {
        public static ListEmapResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEmapResponse listEmapResponse = new ListEmapResponse();

			listEmapResponse.HttpResponse = _ctx.HttpResponse;
			listEmapResponse.ErrorCode = _ctx.StringValue("ListEmap.ErrorCode");
			listEmapResponse.ErrorMessage = _ctx.StringValue("ListEmap.ErrorMessage");
			listEmapResponse.Message = _ctx.StringValue("ListEmap.Message");
			listEmapResponse.Code = _ctx.StringValue("ListEmap.Code");
			listEmapResponse.DynamicCode = _ctx.StringValue("ListEmap.DynamicCode");
			listEmapResponse.RequestId = _ctx.StringValue("ListEmap.RequestId");
			listEmapResponse.Success = _ctx.BooleanValue("ListEmap.Success");
			listEmapResponse.DynamicMessage = _ctx.StringValue("ListEmap.DynamicMessage");

			List<ListEmapResponse.ListEmap_OpenEmap> listEmapResponse_openEmaps = new List<ListEmapResponse.ListEmap_OpenEmap>();
			for (int i = 0; i < _ctx.Length("ListEmap.OpenEmaps.Length"); i++) {
				ListEmapResponse.ListEmap_OpenEmap openEmap = new ListEmapResponse.ListEmap_OpenEmap();
				openEmap.LocationId = _ctx.StringValue("ListEmap.OpenEmaps["+ i +"].LocationId");
				openEmap.EmapId = _ctx.StringValue("ListEmap.OpenEmaps["+ i +"].EmapId");
				openEmap.Name = _ctx.StringValue("ListEmap.OpenEmaps["+ i +"].Name");
				openEmap.EmapUrl = _ctx.StringValue("ListEmap.OpenEmaps["+ i +"].EmapUrl");

				listEmapResponse_openEmaps.Add(openEmap);
			}
			listEmapResponse.OpenEmaps = listEmapResponse_openEmaps;
        
			return listEmapResponse;
        }
    }
}
