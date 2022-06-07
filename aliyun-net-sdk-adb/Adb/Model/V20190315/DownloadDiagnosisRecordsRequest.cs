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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20190315;

namespace Aliyun.Acs.adb.Model.V20190315
{
    public class DownloadDiagnosisRecordsRequest : RpcAcsRequest<DownloadDiagnosisRecordsResponse>
    {
        public DownloadDiagnosisRecordsRequest()
            : base("adb", "2019-03-15", "DownloadDiagnosisRecords", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? maxScanSize;

		private string resourceGroup;

		private string dBClusterId;

		private string queryCondition;

		private string endTime;

		private string startTime;

		private long? minPeakMemory;

		private long? minScanSize;

		private string database;

		private string clientIp;

		private long? maxPeakMemory;

		private string keyword;

		private string lang;

		private string userName;

		public long? MaxScanSize
		{
			get
			{
				return maxScanSize;
			}
			set	
			{
				maxScanSize = value;
				DictionaryUtil.Add(QueryParameters, "MaxScanSize", value.ToString());
			}
		}

		public string ResourceGroup
		{
			get
			{
				return resourceGroup;
			}
			set	
			{
				resourceGroup = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroup", value);
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
			}
		}

		public string QueryCondition
		{
			get
			{
				return queryCondition;
			}
			set	
			{
				queryCondition = value;
				DictionaryUtil.Add(QueryParameters, "QueryCondition", value);
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

		public long? MinPeakMemory
		{
			get
			{
				return minPeakMemory;
			}
			set	
			{
				minPeakMemory = value;
				DictionaryUtil.Add(QueryParameters, "MinPeakMemory", value.ToString());
			}
		}

		public long? MinScanSize
		{
			get
			{
				return minScanSize;
			}
			set	
			{
				minScanSize = value;
				DictionaryUtil.Add(QueryParameters, "MinScanSize", value.ToString());
			}
		}

		public string Database
		{
			get
			{
				return database;
			}
			set	
			{
				database = value;
				DictionaryUtil.Add(QueryParameters, "Database", value);
			}
		}

		public string ClientIp
		{
			get
			{
				return clientIp;
			}
			set	
			{
				clientIp = value;
				DictionaryUtil.Add(QueryParameters, "ClientIp", value);
			}
		}

		public long? MaxPeakMemory
		{
			get
			{
				return maxPeakMemory;
			}
			set	
			{
				maxPeakMemory = value;
				DictionaryUtil.Add(QueryParameters, "MaxPeakMemory", value.ToString());
			}
		}

		public string Keyword
		{
			get
			{
				return keyword;
			}
			set	
			{
				keyword = value;
				DictionaryUtil.Add(QueryParameters, "Keyword", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DownloadDiagnosisRecordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DownloadDiagnosisRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
