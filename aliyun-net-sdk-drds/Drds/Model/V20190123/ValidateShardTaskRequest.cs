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
using Aliyun.Acs.Drds.Transform;
using Aliyun.Acs.Drds.Transform.V20190123;

namespace Aliyun.Acs.Drds.Model.V20190123
{
    public class ValidateShardTaskRequest : RpcAcsRequest<ValidateShardTaskResponse>
    {
        public ValidateShardTaskRequest()
            : base("Drds", "2019-01-23", "ValidateShardTask", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string taskType;

		private string targetTableName;

		private string drdsInstanceId;

		private string dbName;

		private string sourceTableName;

		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
				DictionaryUtil.Add(QueryParameters, "TaskType", value);
			}
		}

		public string TargetTableName
		{
			get
			{
				return targetTableName;
			}
			set	
			{
				targetTableName = value;
				DictionaryUtil.Add(QueryParameters, "TargetTableName", value);
			}
		}

		public string DrdsInstanceId
		{
			get
			{
				return drdsInstanceId;
			}
			set	
			{
				drdsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DrdsInstanceId", value);
			}
		}

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
				DictionaryUtil.Add(QueryParameters, "DbName", value);
			}
		}

		public string SourceTableName
		{
			get
			{
				return sourceTableName;
			}
			set	
			{
				sourceTableName = value;
				DictionaryUtil.Add(QueryParameters, "SourceTableName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ValidateShardTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ValidateShardTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
