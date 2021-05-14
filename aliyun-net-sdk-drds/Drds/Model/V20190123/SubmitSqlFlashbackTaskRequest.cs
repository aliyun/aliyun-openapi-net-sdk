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
    public class SubmitSqlFlashbackTaskRequest : RpcAcsRequest<SubmitSqlFlashbackTaskResponse>
    {
        public SubmitSqlFlashbackTaskRequest()
            : base("Drds", "2019-01-23", "SubmitSqlFlashbackTask", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string traceId;

		private string sqlPk;

		private string startTime;

		private int? recallRestoreType;

		private string tableName;

		private string sqlType;

		private string endTime;

		private string drdsInstanceId;

		private int? recallType;

		private string dbName;

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
				DictionaryUtil.Add(QueryParameters, "TraceId", value);
			}
		}

		public string SqlPk
		{
			get
			{
				return sqlPk;
			}
			set	
			{
				sqlPk = value;
				DictionaryUtil.Add(QueryParameters, "SqlPk", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public int? RecallRestoreType
		{
			get
			{
				return recallRestoreType;
			}
			set	
			{
				recallRestoreType = value;
				DictionaryUtil.Add(QueryParameters, "RecallRestoreType", value.ToString());
			}
		}

		public string TableName
		{
			get
			{
				return tableName;
			}
			set	
			{
				tableName = value;
				DictionaryUtil.Add(QueryParameters, "TableName", value);
			}
		}

		public string SqlType
		{
			get
			{
				return sqlType;
			}
			set	
			{
				sqlType = value;
				DictionaryUtil.Add(QueryParameters, "SqlType", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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

		public int? RecallType
		{
			get
			{
				return recallType;
			}
			set	
			{
				recallType = value;
				DictionaryUtil.Add(QueryParameters, "RecallType", value.ToString());
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

        public override SubmitSqlFlashbackTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitSqlFlashbackTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
