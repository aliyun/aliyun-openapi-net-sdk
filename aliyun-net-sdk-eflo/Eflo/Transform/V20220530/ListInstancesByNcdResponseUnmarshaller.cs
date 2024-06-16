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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class ListInstancesByNcdResponseUnmarshaller
    {
        public static ListInstancesByNcdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesByNcdResponse listInstancesByNcdResponse = new ListInstancesByNcdResponse();

			listInstancesByNcdResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesByNcdResponse.Code = _ctx.IntegerValue("ListInstancesByNcd.Code");
			listInstancesByNcdResponse.Message = _ctx.StringValue("ListInstancesByNcd.Message");
			listInstancesByNcdResponse.RequestId = _ctx.StringValue("ListInstancesByNcd.RequestId");

			ListInstancesByNcdResponse.ListInstancesByNcd_Content content = new ListInstancesByNcdResponse.ListInstancesByNcd_Content();
			content.MaxNcd = _ctx.IntegerValue("ListInstancesByNcd.Content.MaxNcd");
			content.InstanceType = _ctx.StringValue("ListInstancesByNcd.Content.InstanceType");
			content.SourceInstanceId = _ctx.StringValue("ListInstancesByNcd.Content.SourceInstanceId");

			List<ListInstancesByNcdResponse.ListInstancesByNcd_Content.ListInstancesByNcd_InstanceInfo> content_instanceInfos = new List<ListInstancesByNcdResponse.ListInstancesByNcd_Content.ListInstancesByNcd_InstanceInfo>();
			for (int i = 0; i < _ctx.Length("ListInstancesByNcd.Content.InstanceInfos.Length"); i++) {
				ListInstancesByNcdResponse.ListInstancesByNcd_Content.ListInstancesByNcd_InstanceInfo instanceInfo = new ListInstancesByNcdResponse.ListInstancesByNcd_Content.ListInstancesByNcd_InstanceInfo();
				instanceInfo.InstanceId = _ctx.StringValue("ListInstancesByNcd.Content.InstanceInfos["+ i +"].InstanceId");
				instanceInfo.Ncd = _ctx.IntegerValue("ListInstancesByNcd.Content.InstanceInfos["+ i +"].Ncd");

				content_instanceInfos.Add(instanceInfo);
			}
			content.InstanceInfos = content_instanceInfos;
			listInstancesByNcdResponse.Content = content;
        
			return listInstancesByNcdResponse;
        }
    }
}
