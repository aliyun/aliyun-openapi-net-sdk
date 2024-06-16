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
using Aliyun.Acs.nis.Transform;
using Aliyun.Acs.nis.Transform.V20211216;

namespace Aliyun.Acs.nis.Model.V20211216
{
    public class CreateAndAnalyzeNetworkPathRequest : RpcAcsRequest<CreateAndAnalyzeNetworkPathResponse>
    {
        public CreateAndAnalyzeNetworkPathRequest()
            : base("nis", "2021-12-16", "CreateAndAnalyzeNetworkPath", "networkana", "openAPI")
        {
        }

		private string targetId;

		private string targetType;

		private string targetIpAddress;

		private int? sourcePort;

		private string protocol;

		private string sourceType;

		private int? targetPort;

		private string sourceId;

		private string sourceIpAddress;

		public string TargetId
		{
			get
			{
				return targetId;
			}
			set	
			{
				targetId = value;
				DictionaryUtil.Add(QueryParameters, "TargetId", value);
			}
		}

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
				DictionaryUtil.Add(QueryParameters, "TargetType", value);
			}
		}

		public string TargetIpAddress
		{
			get
			{
				return targetIpAddress;
			}
			set	
			{
				targetIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "TargetIpAddress", value);
			}
		}

		public int? SourcePort
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

		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
				DictionaryUtil.Add(QueryParameters, "Protocol", value);
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

		public int? TargetPort
		{
			get
			{
				return targetPort;
			}
			set	
			{
				targetPort = value;
				DictionaryUtil.Add(QueryParameters, "TargetPort", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateAndAnalyzeNetworkPathResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAndAnalyzeNetworkPathResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
