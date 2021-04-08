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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class DescribeConnectionStatusRequest : RpcAcsRequest<DescribeConnectionStatusResponse>
    {
        public DescribeConnectionStatusRequest()
            : base("Dts", "2020-01-01", "DescribeConnectionStatus", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceEndpointRegion;

		private string sourceEndpointArchitecture;

		private string destinationEndpointInstanceType;

		private string sourceEndpointInstanceID;

		private string sourceEndpointUserName;

		private string sourceEndpointDatabaseName;

		private string destinationEndpointRegion;

		private string sourceEndpointIP;

		private string destinationEndpointUserName;

		private string destinationEndpointArchitecture;

		private string destinationEndpointOracleSID;

		private string destinationEndpointEngineName;

		private string destinationEndpointInstanceID;

		private string destinationEndpointPort;

		private string sourceEndpointPassword;

		private string sourceEndpointPort;

		private string destinationEndpointIP;

		private string sourceEndpointInstanceType;

		private string sourceEndpointOracleSID;

		private string destinationEndpointDatabaseName;

		private string destinationEndpointPassword;

		private string sourceEndpointEngineName;

		public string SourceEndpointRegion
		{
			get
			{
				return sourceEndpointRegion;
			}
			set	
			{
				sourceEndpointRegion = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointRegion", value);
			}
		}

		public string SourceEndpointArchitecture
		{
			get
			{
				return sourceEndpointArchitecture;
			}
			set	
			{
				sourceEndpointArchitecture = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointArchitecture", value);
			}
		}

		public string DestinationEndpointInstanceType
		{
			get
			{
				return destinationEndpointInstanceType;
			}
			set	
			{
				destinationEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointInstanceType", value);
			}
		}

		public string SourceEndpointInstanceID
		{
			get
			{
				return sourceEndpointInstanceID;
			}
			set	
			{
				sourceEndpointInstanceID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointInstanceID", value);
			}
		}

		public string SourceEndpointUserName
		{
			get
			{
				return sourceEndpointUserName;
			}
			set	
			{
				sourceEndpointUserName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointUserName", value);
			}
		}

		public string SourceEndpointDatabaseName
		{
			get
			{
				return sourceEndpointDatabaseName;
			}
			set	
			{
				sourceEndpointDatabaseName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointDatabaseName", value);
			}
		}

		public string DestinationEndpointRegion
		{
			get
			{
				return destinationEndpointRegion;
			}
			set	
			{
				destinationEndpointRegion = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointRegion", value);
			}
		}

		public string SourceEndpointIP
		{
			get
			{
				return sourceEndpointIP;
			}
			set	
			{
				sourceEndpointIP = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointIP", value);
			}
		}

		public string DestinationEndpointUserName
		{
			get
			{
				return destinationEndpointUserName;
			}
			set	
			{
				destinationEndpointUserName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointUserName", value);
			}
		}

		public string DestinationEndpointArchitecture
		{
			get
			{
				return destinationEndpointArchitecture;
			}
			set	
			{
				destinationEndpointArchitecture = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointArchitecture", value);
			}
		}

		public string DestinationEndpointOracleSID
		{
			get
			{
				return destinationEndpointOracleSID;
			}
			set	
			{
				destinationEndpointOracleSID = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointOracleSID", value);
			}
		}

		public string DestinationEndpointEngineName
		{
			get
			{
				return destinationEndpointEngineName;
			}
			set	
			{
				destinationEndpointEngineName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointEngineName", value);
			}
		}

		public string DestinationEndpointInstanceID
		{
			get
			{
				return destinationEndpointInstanceID;
			}
			set	
			{
				destinationEndpointInstanceID = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointInstanceID", value);
			}
		}

		public string DestinationEndpointPort
		{
			get
			{
				return destinationEndpointPort;
			}
			set	
			{
				destinationEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointPort", value);
			}
		}

		public string SourceEndpointPassword
		{
			get
			{
				return sourceEndpointPassword;
			}
			set	
			{
				sourceEndpointPassword = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPassword", value);
			}
		}

		public string SourceEndpointPort
		{
			get
			{
				return sourceEndpointPort;
			}
			set	
			{
				sourceEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPort", value);
			}
		}

		public string DestinationEndpointIP
		{
			get
			{
				return destinationEndpointIP;
			}
			set	
			{
				destinationEndpointIP = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointIP", value);
			}
		}

		public string SourceEndpointInstanceType
		{
			get
			{
				return sourceEndpointInstanceType;
			}
			set	
			{
				sourceEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointInstanceType", value);
			}
		}

		public string SourceEndpointOracleSID
		{
			get
			{
				return sourceEndpointOracleSID;
			}
			set	
			{
				sourceEndpointOracleSID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointOracleSID", value);
			}
		}

		public string DestinationEndpointDatabaseName
		{
			get
			{
				return destinationEndpointDatabaseName;
			}
			set	
			{
				destinationEndpointDatabaseName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointDatabaseName", value);
			}
		}

		public string DestinationEndpointPassword
		{
			get
			{
				return destinationEndpointPassword;
			}
			set	
			{
				destinationEndpointPassword = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointPassword", value);
			}
		}

		public string SourceEndpointEngineName
		{
			get
			{
				return sourceEndpointEngineName;
			}
			set	
			{
				sourceEndpointEngineName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointEngineName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeConnectionStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeConnectionStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
