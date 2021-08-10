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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeSubscriptionMetaResponse : AcsResponse
	{

		private string errCode;

		private string errMessage;

		private string httpStatusCode;

		private string requestId;

		private string success;

		private List<DescribeSubscriptionMeta_SubscriptionMetaListItem> subscriptionMetaList;

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public string HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public string Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeSubscriptionMeta_SubscriptionMetaListItem> SubscriptionMetaList
		{
			get
			{
				return subscriptionMetaList;
			}
			set	
			{
				subscriptionMetaList = value;
			}
		}

		public class DescribeSubscriptionMeta_SubscriptionMetaListItem
		{

			private string dProxyUrl;

			private string topic;

			private string sid;

			private long? checkpoint;

			private string dBList;

			public string DProxyUrl
			{
				get
				{
					return dProxyUrl;
				}
				set	
				{
					dProxyUrl = value;
				}
			}

			public string Topic
			{
				get
				{
					return topic;
				}
				set	
				{
					topic = value;
				}
			}

			public string Sid
			{
				get
				{
					return sid;
				}
				set	
				{
					sid = value;
				}
			}

			public long? Checkpoint
			{
				get
				{
					return checkpoint;
				}
				set	
				{
					checkpoint = value;
				}
			}

			public string DBList
			{
				get
				{
					return dBList;
				}
				set	
				{
					dBList = value;
				}
			}
		}
	}
}
