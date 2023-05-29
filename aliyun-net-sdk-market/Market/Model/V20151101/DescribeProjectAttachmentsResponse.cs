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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeProjectAttachmentsResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<DescribeProjectAttachments_ProjectAttachment> result;

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Result")]
		public List<DescribeProjectAttachments_ProjectAttachment> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeProjectAttachments_ProjectAttachment
		{

			private long? fileLinkGmtExpired;

			private int? stepNo;

			private string attachmentToken;

			private string fileName;

			private string operatorRole;

			private string nodeName;

			private string operatorName;

			private string fileLink;

			private long? gmtCreate;

			private string fileSuffix;

			private long? _operator;

			private string content;

			private long? nodeId;

			private string attachmentType;

			private long? fileSize;

			[JsonProperty(PropertyName = "FileLinkGmtExpired")]
			public long? FileLinkGmtExpired
			{
				get
				{
					return fileLinkGmtExpired;
				}
				set	
				{
					fileLinkGmtExpired = value;
				}
			}

			[JsonProperty(PropertyName = "StepNo")]
			public int? StepNo
			{
				get
				{
					return stepNo;
				}
				set	
				{
					stepNo = value;
				}
			}

			[JsonProperty(PropertyName = "AttachmentToken")]
			public string AttachmentToken
			{
				get
				{
					return attachmentToken;
				}
				set	
				{
					attachmentToken = value;
				}
			}

			[JsonProperty(PropertyName = "FileName")]
			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			[JsonProperty(PropertyName = "OperatorRole")]
			public string OperatorRole
			{
				get
				{
					return operatorRole;
				}
				set	
				{
					operatorRole = value;
				}
			}

			[JsonProperty(PropertyName = "NodeName")]
			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
				}
			}

			[JsonProperty(PropertyName = "OperatorName")]
			public string OperatorName
			{
				get
				{
					return operatorName;
				}
				set	
				{
					operatorName = value;
				}
			}

			[JsonProperty(PropertyName = "FileLink")]
			public string FileLink
			{
				get
				{
					return fileLink;
				}
				set	
				{
					fileLink = value;
				}
			}

			[JsonProperty(PropertyName = "GmtCreate")]
			public long? GmtCreate
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

			[JsonProperty(PropertyName = "FileSuffix")]
			public string FileSuffix
			{
				get
				{
					return fileSuffix;
				}
				set	
				{
					fileSuffix = value;
				}
			}

			[JsonProperty(PropertyName = "_Operator")]
			public long? _Operator
			{
				get
				{
					return _operator;
				}
				set	
				{
					_operator = value;
				}
			}

			[JsonProperty(PropertyName = "Content")]
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

			[JsonProperty(PropertyName = "NodeId")]
			public long? NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			[JsonProperty(PropertyName = "AttachmentType")]
			public string AttachmentType
			{
				get
				{
					return attachmentType;
				}
				set	
				{
					attachmentType = value;
				}
			}

			[JsonProperty(PropertyName = "FileSize")]
			public long? FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
				}
			}
		}
	}
}
