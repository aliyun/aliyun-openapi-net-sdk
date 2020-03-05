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
using Aliyun.Acs.OnsMqtt.Transform;
using Aliyun.Acs.OnsMqtt.Transform.V20191211;

namespace Aliyun.Acs.OnsMqtt.Model.V20191211
{
    public class BatchSendMessagesRequest : RpcAcsRequest<BatchSendMessagesResponse>
    {
        public BatchSendMessagesRequest()
            : base("OnsMqtt", "2019-12-11", "BatchSendMessages", "onsmqtt", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string instanceId;

		private List<Messages> messagess = new List<Messages>(){ };

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public List<Messages> Messagess
		{
			get
			{
				return messagess;
			}

			set
			{
				messagess = value;
				for (int i = 0; i < messagess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Messages." + (i + 1) + ".Payload", messagess[i].Payload);
					for (int j = 0; j < messagess[i].Topicss.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Messages." + (i + 1) + ".Topics." +(j + 1), messagess[i].Topicss[j]);
					}
					DictionaryUtil.Add(QueryParameters,"Messages." + (i + 1) + ".Id", messagess[i].Id);
					DictionaryUtil.Add(QueryParameters,"Messages." + (i + 1) + ".ReceiptId", messagess[i].ReceiptId);
				}
			}
		}

		public class Messages
		{

			private string payload;

			private List<string> topicss = new List<string>(){ };

			private int? id;

			private string receiptId;

			public string Payload
			{
				get
				{
					return payload;
				}
				set	
				{
					payload = value;
				}
			}

			public List<string> Topicss
			{
				get
				{
					return topicss;
				}
				set	
				{
					topicss = value;
				}
			}

			public int? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ReceiptId
			{
				get
				{
					return receiptId;
				}
				set	
				{
					receiptId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BatchSendMessagesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchSendMessagesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
