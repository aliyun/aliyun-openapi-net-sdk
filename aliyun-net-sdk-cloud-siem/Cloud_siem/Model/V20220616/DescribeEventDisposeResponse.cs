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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeEventDisposeResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeEventDispose_Data data;

		public bool? Success
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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public DescribeEventDispose_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeEventDispose_Data
		{

			private int? status;

			private string remark;

			private List<string> eventDispose;

			private DescribeEventDispose_ReceiverInfo receiverInfo;

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public List<string> EventDispose
			{
				get
				{
					return eventDispose;
				}
				set	
				{
					eventDispose = value;
				}
			}

			public DescribeEventDispose_ReceiverInfo ReceiverInfo
			{
				get
				{
					return receiverInfo;
				}
				set	
				{
					receiverInfo = value;
				}
			}

			public class DescribeEventDispose_ReceiverInfo
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private string incidentUuid;

				private string messageTitle;

				private string receiver;

				private string channel;

				private int? status;

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

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public string IncidentUuid
				{
					get
					{
						return incidentUuid;
					}
					set	
					{
						incidentUuid = value;
					}
				}

				public string MessageTitle
				{
					get
					{
						return messageTitle;
					}
					set	
					{
						messageTitle = value;
					}
				}

				public string Receiver
				{
					get
					{
						return receiver;
					}
					set	
					{
						receiver = value;
					}
				}

				public string Channel
				{
					get
					{
						return channel;
					}
					set	
					{
						channel = value;
					}
				}

				public int? Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}
