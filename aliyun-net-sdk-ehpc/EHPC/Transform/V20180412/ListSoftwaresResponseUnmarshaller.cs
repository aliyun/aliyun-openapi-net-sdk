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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListSoftwaresResponseUnmarshaller
    {
        public static ListSoftwaresResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSoftwaresResponse listSoftwaresResponse = new ListSoftwaresResponse();

			listSoftwaresResponse.HttpResponse = _ctx.HttpResponse;
			listSoftwaresResponse.RequestId = _ctx.StringValue("ListSoftwares.RequestId");

			List<ListSoftwaresResponse.ListSoftwares_SoftwareInfo> listSoftwaresResponse_softwares = new List<ListSoftwaresResponse.ListSoftwares_SoftwareInfo>();
			for (int i = 0; i < _ctx.Length("ListSoftwares.Softwares.Length"); i++) {
				ListSoftwaresResponse.ListSoftwares_SoftwareInfo softwareInfo = new ListSoftwaresResponse.ListSoftwares_SoftwareInfo();
				softwareInfo.EhpcVersion = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].EhpcVersion");
				softwareInfo.OsTag = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].OsTag");
				softwareInfo.SchedulerType = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].SchedulerType");
				softwareInfo.SchedulerVersion = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].SchedulerVersion");
				softwareInfo.AccountType = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].AccountType");
				softwareInfo.AccountVersion = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].AccountVersion");

				List<ListSoftwaresResponse.ListSoftwares_SoftwareInfo.ListSoftwares_ApplicationInfo> softwareInfo_applications = new List<ListSoftwaresResponse.ListSoftwares_SoftwareInfo.ListSoftwares_ApplicationInfo>();
				for (int j = 0; j < _ctx.Length("ListSoftwares.Softwares["+ i +"].Applications.Length"); j++) {
					ListSoftwaresResponse.ListSoftwares_SoftwareInfo.ListSoftwares_ApplicationInfo applicationInfo = new ListSoftwaresResponse.ListSoftwares_SoftwareInfo.ListSoftwares_ApplicationInfo();
					applicationInfo.Tag = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].Applications["+ j +"].Tag");
					applicationInfo.Name = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].Applications["+ j +"].Name");
					applicationInfo.Version = _ctx.StringValue("ListSoftwares.Softwares["+ i +"].Applications["+ j +"].Version");
					applicationInfo.Required = _ctx.BooleanValue("ListSoftwares.Softwares["+ i +"].Applications["+ j +"].Required");

					softwareInfo_applications.Add(applicationInfo);
				}
				softwareInfo.Applications = softwareInfo_applications;

				listSoftwaresResponse_softwares.Add(softwareInfo);
			}
			listSoftwaresResponse.Softwares = listSoftwaresResponse_softwares;
        
			return listSoftwaresResponse;
        }
    }
}
