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
    public class UpdateJobRequest : RoaAcsRequest<UpdateJobResponse>
    {
        public UpdateJobRequest()
            : base("foas", "2018-11-11", "UpdateJob", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.foas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.foas.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/projects/[projectName]/jobs/[jobName]";
			Method = MethodType.PUT;
        }

		private string queueName;

		private string projectName;

		private string code;

		private string description;

		private string planJson;

		private string engineVersion;

		private string clusterId;

		private string packages;

		private long? folderId;

		private string properties;

		private string jobName;

		public string QueueName
		{
			get
			{
				return queueName;
			}
			set	
			{
				queueName = value;
				DictionaryUtil.Add(BodyParameters, "queueName", value);
			}
		}

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
				DictionaryUtil.Add(BodyParameters, "code", value);
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

		public string PlanJson
		{
			get
			{
				return planJson;
			}
			set	
			{
				planJson = value;
				DictionaryUtil.Add(BodyParameters, "planJson", value);
			}
		}

		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
				DictionaryUtil.Add(BodyParameters, "engineVersion", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(BodyParameters, "clusterId", value);
			}
		}

		public string Packages
		{
			get
			{
				return packages;
			}
			set	
			{
				packages = value;
				DictionaryUtil.Add(BodyParameters, "packages", value);
			}
		}

		public long? FolderId
		{
			get
			{
				return folderId;
			}
			set	
			{
				folderId = value;
				DictionaryUtil.Add(BodyParameters, "folderId", value.ToString());
			}
		}

		public string Properties
		{
			get
			{
				return properties;
			}
			set	
			{
				properties = value;
				DictionaryUtil.Add(BodyParameters, "properties", value);
			}
		}

		public string JobName
		{
			get
			{
				return jobName;
			}
			set	
			{
				jobName = value;
				DictionaryUtil.Add(PathParameters, "jobName", value);
			}
		}

        public override UpdateJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
