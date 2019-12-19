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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class ListEmapResponseUnmarshaller
    {
        public static ListEmapResponse Unmarshall(UnmarshallerContext context)
        {
			ListEmapResponse listEmapResponse = new ListEmapResponse();

			listEmapResponse.HttpResponse = context.HttpResponse;
			listEmapResponse.ErrorCode = context.StringValue("ListEmap.ErrorCode");
			listEmapResponse.ErrorMessage = context.StringValue("ListEmap.ErrorMessage");
			listEmapResponse.RequestId = context.StringValue("ListEmap.RequestId");
			listEmapResponse.Success = context.BooleanValue("ListEmap.Success");

			List<ListEmapResponse.ListEmap_OpenEmap> listEmapResponse_openEmaps = new List<ListEmapResponse.ListEmap_OpenEmap>();
			for (int i = 0; i < context.Length("ListEmap.OpenEmaps.Length"); i++) {
				ListEmapResponse.ListEmap_OpenEmap openEmap = new ListEmapResponse.ListEmap_OpenEmap();
				openEmap.LocationId = context.StringValue("ListEmap.OpenEmaps["+ i +"].LocationId");
				openEmap.EmapId = context.StringValue("ListEmap.OpenEmaps["+ i +"].EmapId");
				openEmap.Name = context.StringValue("ListEmap.OpenEmaps["+ i +"].Name");
				openEmap.EmapUrl = context.StringValue("ListEmap.OpenEmaps["+ i +"].EmapUrl");

				listEmapResponse_openEmaps.Add(openEmap);
			}
			listEmapResponse.OpenEmaps = listEmapResponse_openEmaps;
        
			return listEmapResponse;
        }
    }
}
