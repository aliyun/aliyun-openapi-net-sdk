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
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class ModifyFileSystemRequest : RpcAcsRequest<ModifyFileSystemResponse>
    {
        public ModifyFileSystemRequest()
            : base("NAS", "2017-06-26", "ModifyFileSystem", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private Options options_;

		private string fileSystemId;

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "Options")]
		public Options Options_
		{
			get
			{
				return options_;
			}

			set
			{
				options_ = value;
				DictionaryUtil.Add(QueryParameters, "Options", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "FileSystemId")]
		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemId", value);
			}
		}

		public class Options
		{

			private bool? enableOplock;

			[JsonProperty(PropertyName = "EnableOplock")]
			public bool? EnableOplock
			{
				get
				{
					return enableOplock;
				}
				set	
				{
					enableOplock = value;
				}
			}
		}

        public override ModifyFileSystemResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyFileSystemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
