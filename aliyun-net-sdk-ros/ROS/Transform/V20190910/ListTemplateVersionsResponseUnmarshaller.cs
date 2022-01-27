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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListTemplateVersionsResponseUnmarshaller
    {
        public static ListTemplateVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTemplateVersionsResponse listTemplateVersionsResponse = new ListTemplateVersionsResponse();

			listTemplateVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listTemplateVersionsResponse.RequestId = _ctx.StringValue("ListTemplateVersions.RequestId");
			listTemplateVersionsResponse.NextToken = _ctx.StringValue("ListTemplateVersions.NextToken");

			List<ListTemplateVersionsResponse.ListTemplateVersions_Version> listTemplateVersionsResponse_versions = new List<ListTemplateVersionsResponse.ListTemplateVersions_Version>();
			for (int i = 0; i < _ctx.Length("ListTemplateVersions.Versions.Length"); i++) {
				ListTemplateVersionsResponse.ListTemplateVersions_Version version = new ListTemplateVersionsResponse.ListTemplateVersions_Version();
				version.CreateTime = _ctx.StringValue("ListTemplateVersions.Versions["+ i +"].CreateTime");
				version.UpdateTime = _ctx.StringValue("ListTemplateVersions.Versions["+ i +"].UpdateTime");
				version.TemplateId = _ctx.StringValue("ListTemplateVersions.Versions["+ i +"].TemplateId");
				version.TemplateName = _ctx.StringValue("ListTemplateVersions.Versions["+ i +"].TemplateName");
				version.TemplateVersion = _ctx.StringValue("ListTemplateVersions.Versions["+ i +"].TemplateVersion");
				version.Description = _ctx.StringValue("ListTemplateVersions.Versions["+ i +"].Description");

				listTemplateVersionsResponse_versions.Add(version);
			}
			listTemplateVersionsResponse.Versions = listTemplateVersionsResponse_versions;
        
			return listTemplateVersionsResponse;
        }
    }
}
