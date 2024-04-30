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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateCloudMigrationTaskRequest : RpcAcsRequest<CreateCloudMigrationTaskResponse>
    {
        public CreateCloudMigrationTaskRequest()
            : base("Rds", "2014-08-15", "CreateCloudMigrationTask", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBInstanceName;

		private long? resourceOwnerId;

		private string taskName;

		private string sourceAccount;

		private long? sourcePort;

		private string sourcePassword;

		private string sourceIpAddress;

		private string sourceCategory;

		[JsonProperty(PropertyName = "DBInstanceName")]
		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceName", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerId")]
		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TaskName")]
		public string TaskName
		{
			get
			{
				return taskName;
			}
			set	
			{
				taskName = value;
				DictionaryUtil.Add(QueryParameters, "TaskName", value);
			}
		}

		[JsonProperty(PropertyName = "SourceAccount")]
		public string SourceAccount
		{
			get
			{
				return sourceAccount;
			}
			set	
			{
				sourceAccount = value;
				DictionaryUtil.Add(QueryParameters, "SourceAccount", value);
			}
		}

		[JsonProperty(PropertyName = "SourcePort")]
		public long? SourcePort
		{
			get
			{
				return sourcePort;
			}
			set	
			{
				sourcePort = value;
				DictionaryUtil.Add(QueryParameters, "SourcePort", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SourcePassword")]
		public string SourcePassword
		{
			get
			{
				return sourcePassword;
			}
			set	
			{
				sourcePassword = value;
				DictionaryUtil.Add(QueryParameters, "SourcePassword", value);
			}
		}

		[JsonProperty(PropertyName = "SourceIpAddress")]
		public string SourceIpAddress
		{
			get
			{
				return sourceIpAddress;
			}
			set	
			{
				sourceIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "SourceIpAddress", value);
			}
		}

		[JsonProperty(PropertyName = "SourceCategory")]
		public string SourceCategory
		{
			get
			{
				return sourceCategory;
			}
			set	
			{
				sourceCategory = value;
				DictionaryUtil.Add(QueryParameters, "SourceCategory", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateCloudMigrationTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCloudMigrationTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
