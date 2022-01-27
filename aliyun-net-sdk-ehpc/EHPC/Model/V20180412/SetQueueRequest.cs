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
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class SetQueueRequest : RpcAcsRequest<SetQueueResponse>
    {
        public SetQueueRequest()
            : base("EHPC", "2018-04-12", "SetQueue")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private string queueName;

		private string clusterId;

		private List<Node> nodes = new List<Node>(){ };

		public string QueueName
		{
			get
			{
				return queueName;
			}
			set	
			{
				queueName = value;
				DictionaryUtil.Add(QueryParameters, "QueueName", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public List<Node> Nodes
		{
			get
			{
				return nodes;
			}

			set
			{
				nodes = value;
				for (int i = 0; i < nodes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Node." + (i + 1) + ".Name", nodes[i].Name);
				}
			}
		}

		public class Node
		{

			private string name;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}
		}

        public override SetQueueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetQueueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
