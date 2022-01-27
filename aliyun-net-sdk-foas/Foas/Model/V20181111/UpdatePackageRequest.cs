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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.foas.Transform;
using Aliyun.Acs.foas.Transform.V20181111;

namespace Aliyun.Acs.foas.Model.V20181111
{
    public class UpdatePackageRequest : RoaAcsRequest<UpdatePackageResponse>
    {
        public UpdatePackageRequest()
            : base("foas", "2018-11-11", "UpdatePackage", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.foas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.foas.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/projects/[projectName]/packages/[packageName]";
			Method = MethodType.PUT;
        }

		private string projectName;

		private string ossBucket;

		private string ossOwner;

		private string packageName;

		private string ossEndpoint;

		private string description;

		private string tag;

		private string originName;

		private string ossPath;

		private string md5;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(PathParameters, "projectName", value);
			}
		}

		public string OssBucket
		{
			get
			{
				return ossBucket;
			}
			set	
			{
				ossBucket = value;
				DictionaryUtil.Add(BodyParameters, "ossBucket", value);
			}
		}

		public string OssOwner
		{
			get
			{
				return ossOwner;
			}
			set	
			{
				ossOwner = value;
				DictionaryUtil.Add(BodyParameters, "ossOwner", value);
			}
		}

		public string PackageName
		{
			get
			{
				return packageName;
			}
			set	
			{
				packageName = value;
				DictionaryUtil.Add(PathParameters, "packageName", value);
			}
		}

		public string OssEndpoint
		{
			get
			{
				return ossEndpoint;
			}
			set	
			{
				ossEndpoint = value;
				DictionaryUtil.Add(BodyParameters, "ossEndpoint", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "description", value);
			}
		}

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
				DictionaryUtil.Add(BodyParameters, "tag", value);
			}
		}

		public string OriginName
		{
			get
			{
				return originName;
			}
			set	
			{
				originName = value;
				DictionaryUtil.Add(BodyParameters, "originName", value);
			}
		}

		public string OssPath
		{
			get
			{
				return ossPath;
			}
			set	
			{
				ossPath = value;
				DictionaryUtil.Add(BodyParameters, "ossPath", value);
			}
		}

		public string Md5
		{
			get
			{
				return md5;
			}
			set	
			{
				md5 = value;
				DictionaryUtil.Add(BodyParameters, "md5", value);
			}
		}

        public override UpdatePackageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdatePackageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
