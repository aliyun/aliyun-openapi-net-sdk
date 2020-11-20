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
using Aliyun.Acs.HBase.Transform;
using Aliyun.Acs.HBase.Transform.V20190101;

namespace Aliyun.Acs.HBase.Model.V20190101
{
    public class EnableHBaseueBackupRequest : RpcAcsRequest<EnableHBaseueBackupResponse>
    {
        public EnableHBaseueBackupRequest()
            : base("HBase", "2019-01-01", "EnableHBaseueBackup", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string hbaseueClusterId;

		private int? coldStorageSize;

		private int? nodeCount;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string HbaseueClusterId
		{
			get
			{
				return hbaseueClusterId;
			}
			set	
			{
				hbaseueClusterId = value;
				DictionaryUtil.Add(QueryParameters, "HbaseueClusterId", value);
			}
		}

		public int? ColdStorageSize
		{
			get
			{
				return coldStorageSize;
			}
			set	
			{
				coldStorageSize = value;
				DictionaryUtil.Add(QueryParameters, "ColdStorageSize", value.ToString());
			}
		}

		public int? NodeCount
		{
			get
			{
				return nodeCount;
			}
			set	
			{
				nodeCount = value;
				DictionaryUtil.Add(QueryParameters, "NodeCount", value.ToString());
			}
		}

        public override EnableHBaseueBackupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EnableHBaseueBackupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
