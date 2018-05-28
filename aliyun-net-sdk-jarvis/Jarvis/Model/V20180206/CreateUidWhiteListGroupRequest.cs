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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.jarvis.Transform;
using Aliyun.Acs.jarvis.Transform.V20180206;
using System.Collections.Generic;

namespace Aliyun.Acs.jarvis.Model.V20180206
{
    public class CreateUidWhiteListGroupRequest : RpcAcsRequest<CreateUidWhiteListGroupResponse>
    {
        public CreateUidWhiteListGroupRequest()
            : base("jarvis", "2018-02-06", "CreateUidWhiteListGroup")
        {
        }

		private string note;

		private long? resourceOwnerId;

		private string sourceIp;

		private int? dstPort;

		private string instanceIdList;

		private int? liveTime;

		private string productName;

		private int? whiteListType;

		private string lang;

		private string srcUid;

		private string sourceCode;

		public string Note
		{
			get
			{
				return note;
			}
			set	
			{
				note = value;
				DictionaryUtil.Add(QueryParameters, "Note", value);
			}
		}

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

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public int? DstPort
		{
			get
			{
				return dstPort;
			}
			set	
			{
				dstPort = value;
				DictionaryUtil.Add(QueryParameters, "DstPort", value.ToString());
			}
		}

		public string InstanceIdList
		{
			get
			{
				return instanceIdList;
			}
			set	
			{
				instanceIdList = value;
				DictionaryUtil.Add(QueryParameters, "InstanceIdList", value);
			}
		}

		public int? LiveTime
		{
			get
			{
				return liveTime;
			}
			set	
			{
				liveTime = value;
				DictionaryUtil.Add(QueryParameters, "LiveTime", value.ToString());
			}
		}

		public string ProductName
		{
			get
			{
				return productName;
			}
			set	
			{
				productName = value;
				DictionaryUtil.Add(QueryParameters, "ProductName", value);
			}
		}

		public int? WhiteListType
		{
			get
			{
				return whiteListType;
			}
			set	
			{
				whiteListType = value;
				DictionaryUtil.Add(QueryParameters, "WhiteListType", value.ToString());
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

		public string SrcUid
		{
			get
			{
				return srcUid;
			}
			set	
			{
				srcUid = value;
				DictionaryUtil.Add(QueryParameters, "SrcUid", value);
			}
		}

		public string SourceCode
		{
			get
			{
				return sourceCode;
			}
			set	
			{
				sourceCode = value;
				DictionaryUtil.Add(QueryParameters, "SourceCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateUidWhiteListGroupResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateUidWhiteListGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}