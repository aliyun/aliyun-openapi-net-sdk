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
    public class CreateCpmcPunishFeedBackRequest : RpcAcsRequest<CreateCpmcPunishFeedBackResponse>
    {
        public CreateCpmcPunishFeedBackRequest()
            : base("jarvis", "2018-02-06", "CreateCpmcPunishFeedBack")
        {
        }

		private int? feedBack;

		private string srcIP;

		private string sourceIp;

		private int? dstPort;

		private string protocolName;

		private int? srcPort;

		private string punishType;

		private string gmtCreate;

		private string dstIP;

		private string lang;

		private string sourceCode;

		public int? FeedBack
		{
			get
			{
				return feedBack;
			}
			set	
			{
				feedBack = value;
				DictionaryUtil.Add(QueryParameters, "FeedBack", value.ToString());
			}
		}

		public string SrcIP
		{
			get
			{
				return srcIP;
			}
			set	
			{
				srcIP = value;
				DictionaryUtil.Add(QueryParameters, "SrcIP", value);
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

		public string ProtocolName
		{
			get
			{
				return protocolName;
			}
			set	
			{
				protocolName = value;
				DictionaryUtil.Add(QueryParameters, "ProtocolName", value);
			}
		}

		public int? SrcPort
		{
			get
			{
				return srcPort;
			}
			set	
			{
				srcPort = value;
				DictionaryUtil.Add(QueryParameters, "SrcPort", value.ToString());
			}
		}

		public string PunishType
		{
			get
			{
				return punishType;
			}
			set	
			{
				punishType = value;
				DictionaryUtil.Add(QueryParameters, "PunishType", value);
			}
		}

		public string GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
				DictionaryUtil.Add(QueryParameters, "GmtCreate", value);
			}
		}

		public string DstIP
		{
			get
			{
				return dstIP;
			}
			set	
			{
				dstIP = value;
				DictionaryUtil.Add(QueryParameters, "DstIP", value);
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

        public override CreateCpmcPunishFeedBackResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateCpmcPunishFeedBackResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}