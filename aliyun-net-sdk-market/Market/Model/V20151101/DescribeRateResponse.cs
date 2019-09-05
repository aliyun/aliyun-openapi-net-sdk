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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeRateResponse : AcsResponse
	{

		private long? id;

		private string orderId;

		private string instanceId;

		private long? aliUid;

		private string productId;

		private string score;

		private string content;

		private long? gmtCreated;

		private string explaintion;

		private long? gmtExplaintion;

		private string additionalContent;

		private long? gmtAdditional;

		private string additionalExplaintion;

		private long? gmtAdditionalExplaintion;

		private string type;

		private string requestId;

		public long? Id
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

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public long? AliUid
		{
			get
			{
				return aliUid;
			}
			set	
			{
				aliUid = value;
			}
		}

		public string ProductId
		{
			get
			{
				return productId;
			}
			set	
			{
				productId = value;
			}
		}

		public string Score
		{
			get
			{
				return score;
			}
			set	
			{
				score = value;
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public long? GmtCreated
		{
			get
			{
				return gmtCreated;
			}
			set	
			{
				gmtCreated = value;
			}
		}

		public string Explaintion
		{
			get
			{
				return explaintion;
			}
			set	
			{
				explaintion = value;
			}
		}

		public long? GmtExplaintion
		{
			get
			{
				return gmtExplaintion;
			}
			set	
			{
				gmtExplaintion = value;
			}
		}

		public string AdditionalContent
		{
			get
			{
				return additionalContent;
			}
			set	
			{
				additionalContent = value;
			}
		}

		public long? GmtAdditional
		{
			get
			{
				return gmtAdditional;
			}
			set	
			{
				gmtAdditional = value;
			}
		}

		public string AdditionalExplaintion
		{
			get
			{
				return additionalExplaintion;
			}
			set	
			{
				additionalExplaintion = value;
			}
		}

		public long? GmtAdditionalExplaintion
		{
			get
			{
				return gmtAdditionalExplaintion;
			}
			set	
			{
				gmtAdditionalExplaintion = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}
	}
}
