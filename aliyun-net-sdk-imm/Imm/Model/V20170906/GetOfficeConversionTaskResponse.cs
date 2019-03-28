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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class GetOfficeConversionTaskResponse : AcsResponse
	{

		private string requestId;

		private string tgtType;

		private string status;

		private int? percent;

		private int? pageCount;

		private string taskId;

		private string tgtUri;

		private string imageSpec;

		private string notifyTopicName;

		private string notifyEndpoint;

		private string externalID;

		private string createTime;

		private string finishTime;

		private string srcUri;

		private GetOfficeConversionTask_FailDetail failDetail;

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

		public string TgtType
		{
			get
			{
				return tgtType;
			}
			set	
			{
				tgtType = value;
			}
		}

		public string Status
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

		public int? Percent
		{
			get
			{
				return percent;
			}
			set	
			{
				percent = value;
			}
		}

		public int? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}

		public string TgtUri
		{
			get
			{
				return tgtUri;
			}
			set	
			{
				tgtUri = value;
			}
		}

		public string ImageSpec
		{
			get
			{
				return imageSpec;
			}
			set	
			{
				imageSpec = value;
			}
		}

		public string NotifyTopicName
		{
			get
			{
				return notifyTopicName;
			}
			set	
			{
				notifyTopicName = value;
			}
		}

		public string NotifyEndpoint
		{
			get
			{
				return notifyEndpoint;
			}
			set	
			{
				notifyEndpoint = value;
			}
		}

		public string ExternalID
		{
			get
			{
				return externalID;
			}
			set	
			{
				externalID = value;
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

		public string FinishTime
		{
			get
			{
				return finishTime;
			}
			set	
			{
				finishTime = value;
			}
		}

		public string SrcUri
		{
			get
			{
				return srcUri;
			}
			set	
			{
				srcUri = value;
			}
		}

		public GetOfficeConversionTask_FailDetail FailDetail
		{
			get
			{
				return failDetail;
			}
			set	
			{
				failDetail = value;
			}
		}

		public class GetOfficeConversionTask_FailDetail
		{

			private string code;

			public string Code
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
		}
	}
}
