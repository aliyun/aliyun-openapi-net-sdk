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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListScenesResponseUnmarshaller
    {
        public static ListScenesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScenesResponse listScenesResponse = new ListScenesResponse();

			listScenesResponse.HttpResponse = _ctx.HttpResponse;
			listScenesResponse.RequestId = _ctx.StringValue("ListScenes.requestId");
			listScenesResponse.Code = _ctx.StringValue("ListScenes.code");
			listScenesResponse.Message = _ctx.StringValue("ListScenes.message");

			List<ListScenesResponse.ListScenes_ResultItem> listScenesResponse_result = new List<ListScenesResponse.ListScenes_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListScenes.Result.Length"); i++) {
				ListScenesResponse.ListScenes_ResultItem resultItem = new ListScenesResponse.ListScenes_ResultItem();
				resultItem.GmtCreate = _ctx.StringValue("ListScenes.Result["+ i +"].gmtCreate");
				resultItem.GmtModified = _ctx.StringValue("ListScenes.Result["+ i +"].gmtModified");
				resultItem.SceneId = _ctx.StringValue("ListScenes.Result["+ i +"].sceneId");
				resultItem.Status = _ctx.StringValue("ListScenes.Result["+ i +"].status");

				listScenesResponse_result.Add(resultItem);
			}
			listScenesResponse.Result = listScenesResponse_result;
        
			return listScenesResponse;
        }
    }
}
