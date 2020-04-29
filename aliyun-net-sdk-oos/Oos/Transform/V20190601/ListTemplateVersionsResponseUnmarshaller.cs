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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListTemplateVersionsResponseUnmarshaller
    {
        public static ListTemplateVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTemplateVersionsResponse listTemplateVersionsResponse = new ListTemplateVersionsResponse();

			listTemplateVersionsResponse.HttpResponse = context.HttpResponse;
			listTemplateVersionsResponse.RequestId = context.StringValue("ListTemplateVersions.RequestId");
			listTemplateVersionsResponse.MaxResults = context.IntegerValue("ListTemplateVersions.MaxResults");
			listTemplateVersionsResponse.NextToken = context.StringValue("ListTemplateVersions.NextToken");

			List<ListTemplateVersionsResponse.ListTemplateVersions_TemplateVersion> listTemplateVersionsResponse_templateVersions = new List<ListTemplateVersionsResponse.ListTemplateVersions_TemplateVersion>();
			for (int i = 0; i < context.Length("ListTemplateVersions.TemplateVersions.Length"); i++) {
				ListTemplateVersionsResponse.ListTemplateVersions_TemplateVersion templateVersion = new ListTemplateVersionsResponse.ListTemplateVersions_TemplateVersion();
				templateVersion.Description = context.StringValue("ListTemplateVersions.TemplateVersions["+ i +"].Description");
				templateVersion.TemplateFormat = context.StringValue("ListTemplateVersions.TemplateVersions["+ i +"].TemplateFormat");
				templateVersion.TemplateVersion = context.StringValue("ListTemplateVersions.TemplateVersions["+ i +"].TemplateVersion");
				templateVersion.UpdatedDate = context.StringValue("ListTemplateVersions.TemplateVersions["+ i +"].UpdatedDate");
				templateVersion.UpdatedBy = context.StringValue("ListTemplateVersions.TemplateVersions["+ i +"].UpdatedBy");
				templateVersion.VersionName = context.StringValue("ListTemplateVersions.TemplateVersions["+ i +"].VersionName");

				listTemplateVersionsResponse_templateVersions.Add(templateVersion);
			}
			listTemplateVersionsResponse.TemplateVersions = listTemplateVersionsResponse_templateVersions;
        
			return listTemplateVersionsResponse;
        }
    }
}
