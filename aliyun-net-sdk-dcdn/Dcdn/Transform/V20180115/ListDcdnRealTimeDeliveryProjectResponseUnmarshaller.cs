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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class ListDcdnRealTimeDeliveryProjectResponseUnmarshaller
    {
        public static ListDcdnRealTimeDeliveryProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDcdnRealTimeDeliveryProjectResponse listDcdnRealTimeDeliveryProjectResponse = new ListDcdnRealTimeDeliveryProjectResponse();

			listDcdnRealTimeDeliveryProjectResponse.HttpResponse = _ctx.HttpResponse;
			listDcdnRealTimeDeliveryProjectResponse.RequestId = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.RequestId");
			listDcdnRealTimeDeliveryProjectResponse.TotalCount = _ctx.IntegerValue("ListDcdnRealTimeDeliveryProject.TotalCount");

			List<ListDcdnRealTimeDeliveryProjectResponse.ListDcdnRealTimeDeliveryProject_Projects> listDcdnRealTimeDeliveryProjectResponse_content = new List<ListDcdnRealTimeDeliveryProjectResponse.ListDcdnRealTimeDeliveryProject_Projects>();
			for (int i = 0; i < _ctx.Length("ListDcdnRealTimeDeliveryProject.Content.Length"); i++) {
				ListDcdnRealTimeDeliveryProjectResponse.ListDcdnRealTimeDeliveryProject_Projects projects = new ListDcdnRealTimeDeliveryProjectResponse.ListDcdnRealTimeDeliveryProject_Projects();
				projects.ProjectName = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].ProjectName");
				projects.Type = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].Type");
				projects.DomainName = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].DomainName");
				projects.FieldName = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].FieldName");
				projects.SamplingRate = _ctx.FloatValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].SamplingRate");
				projects.DataCenter = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].DataCenter");
				projects.SLSRegion = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].SLSRegion");
				projects.SLSProject = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].SLSProject");
				projects.SLSLogStore = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].SLSLogStore");
				projects.BusinessType = _ctx.StringValue("ListDcdnRealTimeDeliveryProject.Content["+ i +"].BusinessType");

				listDcdnRealTimeDeliveryProjectResponse_content.Add(projects);
			}
			listDcdnRealTimeDeliveryProjectResponse.Content = listDcdnRealTimeDeliveryProjectResponse_content;
        
			return listDcdnRealTimeDeliveryProjectResponse;
        }
    }
}
