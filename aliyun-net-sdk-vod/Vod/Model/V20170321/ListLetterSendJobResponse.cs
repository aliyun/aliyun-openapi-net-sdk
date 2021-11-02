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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class ListLetterSendJobResponse : AcsResponse
	{

		private string requestId;

		private List<ListLetterSendJob_LetterJob> letterJobList;

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

		public List<ListLetterSendJob_LetterJob> LetterJobList
		{
			get
			{
				return letterJobList;
			}
			set	
			{
				letterJobList = value;
			}
		}

		public class ListLetterSendJob_LetterJob
		{

			private string ccAddress;

			private string createTime;

			private long? userId;

			private string sendTime;

			private string toAddress;

			private string body;

			private string detectionId;

			private string bccAddress;

			private string jobId;

			private string title;

			private string templateId;

			private string modifyTime;

			public string CcAddress
			{
				get
				{
					return ccAddress;
				}
				set	
				{
					ccAddress = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string SendTime
			{
				get
				{
					return sendTime;
				}
				set	
				{
					sendTime = value;
				}
			}

			public string ToAddress
			{
				get
				{
					return toAddress;
				}
				set	
				{
					toAddress = value;
				}
			}

			public string Body
			{
				get
				{
					return body;
				}
				set	
				{
					body = value;
				}
			}

			public string DetectionId
			{
				get
				{
					return detectionId;
				}
				set	
				{
					detectionId = value;
				}
			}

			public string BccAddress
			{
				get
				{
					return bccAddress;
				}
				set	
				{
					bccAddress = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}
		}
	}
}
