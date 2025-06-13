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
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class CreateGlobalDataNetworkRequest : RpcAcsRequest<CreateGlobalDataNetworkResponse>
    {
        public CreateGlobalDataNetworkRequest()
            : base("polardb", "2017-08-01", "CreateGlobalDataNetwork", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string destinationType;

		private string description;

		private string sourceType;

		private string freezeSourceDuringSync;

		private string sourceId;

		private string destinationRegion;

		private string destinationId;

		private string sourceFileSystemPath;

		private string destinationFileSystemPath;

		private string sourceRegion;

		public string DestinationType
		{
			get
			{
				return destinationType;
			}
			set	
			{
				destinationType = value;
				DictionaryUtil.Add(QueryParameters, "DestinationType", value);
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public string FreezeSourceDuringSync
		{
			get
			{
				return freezeSourceDuringSync;
			}
			set	
			{
				freezeSourceDuringSync = value;
				DictionaryUtil.Add(QueryParameters, "FreezeSourceDuringSync", value);
			}
		}

		public string SourceId
		{
			get
			{
				return sourceId;
			}
			set	
			{
				sourceId = value;
				DictionaryUtil.Add(QueryParameters, "SourceId", value);
			}
		}

		public string DestinationRegion
		{
			get
			{
				return destinationRegion;
			}
			set	
			{
				destinationRegion = value;
				DictionaryUtil.Add(QueryParameters, "DestinationRegion", value);
			}
		}

		public string DestinationId
		{
			get
			{
				return destinationId;
			}
			set	
			{
				destinationId = value;
				DictionaryUtil.Add(QueryParameters, "DestinationId", value);
			}
		}

		public string SourceFileSystemPath
		{
			get
			{
				return sourceFileSystemPath;
			}
			set	
			{
				sourceFileSystemPath = value;
				DictionaryUtil.Add(QueryParameters, "SourceFileSystemPath", value);
			}
		}

		public string DestinationFileSystemPath
		{
			get
			{
				return destinationFileSystemPath;
			}
			set	
			{
				destinationFileSystemPath = value;
				DictionaryUtil.Add(QueryParameters, "DestinationFileSystemPath", value);
			}
		}

		public string SourceRegion
		{
			get
			{
				return sourceRegion;
			}
			set	
			{
				sourceRegion = value;
				DictionaryUtil.Add(QueryParameters, "SourceRegion", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateGlobalDataNetworkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGlobalDataNetworkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
