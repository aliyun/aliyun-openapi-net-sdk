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
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class ListEnvsResponseUnmarshaller
    {
        public static ListEnvsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEnvsResponse listEnvsResponse = new ListEnvsResponse();

			listEnvsResponse.HttpResponse = _ctx.HttpResponse;
			listEnvsResponse.TotalCount = _ctx.LongValue("ListEnvs.TotalCount");
			listEnvsResponse.RequestId = _ctx.StringValue("ListEnvs.RequestId");
			listEnvsResponse.Message = _ctx.StringValue("ListEnvs.Message");
			listEnvsResponse.PageSize = _ctx.IntegerValue("ListEnvs.PageSize");
			listEnvsResponse.PageNumber = _ctx.IntegerValue("ListEnvs.PageNumber");
			listEnvsResponse.HttpStatusCode = _ctx.IntegerValue("ListEnvs.HttpStatusCode");
			listEnvsResponse.Code = _ctx.StringValue("ListEnvs.Code");
			listEnvsResponse.Success = _ctx.BooleanValue("ListEnvs.Success");

			List<ListEnvsResponse.ListEnvs_Env> listEnvsResponse_envs = new List<ListEnvsResponse.ListEnvs_Env>();
			for (int i = 0; i < _ctx.Length("ListEnvs.Envs.Length"); i++) {
				ListEnvsResponse.ListEnvs_Env env = new ListEnvsResponse.ListEnvs_Env();
				env.CreateTime = _ctx.LongValue("ListEnvs.Envs["+ i +"].CreateTime");
				env.EnvVersion = _ctx.StringValue("ListEnvs.Envs["+ i +"].EnvVersion");
				env.ModifiedTime = _ctx.LongValue("ListEnvs.Envs["+ i +"].ModifiedTime");
				env.UsedCapacity = _ctx.LongValue("ListEnvs.Envs["+ i +"].UsedCapacity");
				env.EnvName = _ctx.StringValue("ListEnvs.Envs["+ i +"].EnvName");
				env.EnvId = _ctx.StringValue("ListEnvs.Envs["+ i +"].EnvId");

				List<string> env_runningScenes = new List<string>();
				for (int j = 0; j < _ctx.Length("ListEnvs.Envs["+ i +"].RunningScenes.Length"); j++) {
					env_runningScenes.Add(_ctx.StringValue("ListEnvs.Envs["+ i +"].RunningScenes["+ j +"]"));
				}
				env.RunningScenes = env_runningScenes;

				List<string> env_relatedScenes = new List<string>();
				for (int j = 0; j < _ctx.Length("ListEnvs.Envs["+ i +"].RelatedScenes.Length"); j++) {
					env_relatedScenes.Add(_ctx.StringValue("ListEnvs.Envs["+ i +"].RelatedScenes["+ j +"]"));
				}
				env.RelatedScenes = env_relatedScenes;

				List<ListEnvsResponse.ListEnvs_Env.ListEnvs_File> env_files = new List<ListEnvsResponse.ListEnvs_Env.ListEnvs_File>();
				for (int j = 0; j < _ctx.Length("ListEnvs.Envs["+ i +"].Files.Length"); j++) {
					ListEnvsResponse.ListEnvs_Env.ListEnvs_File file = new ListEnvsResponse.ListEnvs_Env.ListEnvs_File();
					file.FileSize = _ctx.LongValue("ListEnvs.Envs["+ i +"].Files["+ j +"].FileSize");
					file.Md5 = _ctx.StringValue("ListEnvs.Envs["+ i +"].Files["+ j +"].Md5");
					file.FileName = _ctx.StringValue("ListEnvs.Envs["+ i +"].Files["+ j +"].FileName");
					file.FileOssAddress = _ctx.StringValue("ListEnvs.Envs["+ i +"].Files["+ j +"].FileOssAddress");
					file.FileId = _ctx.LongValue("ListEnvs.Envs["+ i +"].Files["+ j +"].FileId");

					env_files.Add(file);
				}
				env.Files = env_files;

				List<ListEnvsResponse.ListEnvs_Env.ListEnvs_PropertiesItem> env_properties = new List<ListEnvsResponse.ListEnvs_Env.ListEnvs_PropertiesItem>();
				for (int j = 0; j < _ctx.Length("ListEnvs.Envs["+ i +"].Properties.Length"); j++) {
					ListEnvsResponse.ListEnvs_Env.ListEnvs_PropertiesItem propertiesItem = new ListEnvsResponse.ListEnvs_Env.ListEnvs_PropertiesItem();
					propertiesItem.Name = _ctx.StringValue("ListEnvs.Envs["+ i +"].Properties["+ j +"].Name");
					propertiesItem._Value = _ctx.StringValue("ListEnvs.Envs["+ i +"].Properties["+ j +"].Value");
					propertiesItem.Description = _ctx.StringValue("ListEnvs.Envs["+ i +"].Properties["+ j +"].Description");

					env_properties.Add(propertiesItem);
				}
				env.Properties = env_properties;

				listEnvsResponse_envs.Add(env);
			}
			listEnvsResponse.Envs = listEnvsResponse_envs;
        
			return listEnvsResponse;
        }
    }
}
