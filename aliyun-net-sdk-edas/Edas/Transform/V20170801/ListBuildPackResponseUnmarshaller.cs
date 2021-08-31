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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListBuildPackResponseUnmarshaller
    {
        public static ListBuildPackResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBuildPackResponse listBuildPackResponse = new ListBuildPackResponse();

			listBuildPackResponse.HttpResponse = _ctx.HttpResponse;
			listBuildPackResponse.Code = _ctx.IntegerValue("ListBuildPack.Code");
			listBuildPackResponse.Message = _ctx.StringValue("ListBuildPack.Message");
			listBuildPackResponse.RequestId = _ctx.StringValue("ListBuildPack.RequestId");

			List<ListBuildPackResponse.ListBuildPack_BuildPack> listBuildPackResponse_buildPackList = new List<ListBuildPackResponse.ListBuildPack_BuildPack>();
			for (int i = 0; i < _ctx.Length("ListBuildPack.BuildPackList.Length"); i++) {
				ListBuildPackResponse.ListBuildPack_BuildPack buildPack = new ListBuildPackResponse.ListBuildPack_BuildPack();
				buildPack.ConfigId = _ctx.LongValue("ListBuildPack.BuildPackList["+ i +"].ConfigId");
				buildPack.PackVersion = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].PackVersion");
				buildPack.TomcatDesc = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].TomcatDesc");
				buildPack.TomcatVersion = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].TomcatVersion");
				buildPack.TomcatDownloadUrl = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].TomcatDownloadUrl");
				buildPack.PandoraVersion = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].PandoraVersion");
				buildPack.PandoraDownloadUrl = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].PandoraDownloadUrl");
				buildPack.PandoraDesc = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].PandoraDesc");
				buildPack.PluginInfo = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].PluginInfo");
				buildPack.TomcatPath = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].TomcatPath");
				buildPack.ImageId = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].ImageId");
				buildPack.TengineImageId = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].TengineImageId");
				buildPack.MultipleTenant = _ctx.BooleanValue("ListBuildPack.BuildPackList["+ i +"].MultipleTenant");
				buildPack.WithTengine = _ctx.BooleanValue("ListBuildPack.BuildPackList["+ i +"].WithTengine");
				buildPack.TengineDownloadUrl = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].TengineDownloadUrl");
				buildPack.ScriptName = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].ScriptName");
				buildPack.ScriptVersion = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].ScriptVersion");
				buildPack.Feature = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].Feature");
				buildPack.SupportFeatures = _ctx.StringValue("ListBuildPack.BuildPackList["+ i +"].SupportFeatures");
				buildPack.Disabled = _ctx.BooleanValue("ListBuildPack.BuildPackList["+ i +"].Disabled");

				listBuildPackResponse_buildPackList.Add(buildPack);
			}
			listBuildPackResponse.BuildPackList = listBuildPackResponse_buildPackList;
        
			return listBuildPackResponse;
        }
    }
}
