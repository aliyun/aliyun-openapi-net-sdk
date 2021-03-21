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
	public class IndexVideoResponse : AcsResponse
	{

		private string modifyTime;

		private string requestId;

		private string endTime;

		private bool? saveType;

		private string externalId;

		private string createTime;

		private string startTime;

		private string videoUri;

		private string grabType;

		private string remarksA;

		private string remarksB;

		private string remarksC;

		private string tgtUri;

		private string remarksD;

		private string setId;

		private float? interval;

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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public bool? SaveType
		{
			get
			{
				return saveType;
			}
			set	
			{
				saveType = value;
			}
		}

		public string ExternalId
		{
			get
			{
				return externalId;
			}
			set	
			{
				externalId = value;
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

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public string VideoUri
		{
			get
			{
				return videoUri;
			}
			set	
			{
				videoUri = value;
			}
		}

		public string GrabType
		{
			get
			{
				return grabType;
			}
			set	
			{
				grabType = value;
			}
		}

		public string RemarksA
		{
			get
			{
				return remarksA;
			}
			set	
			{
				remarksA = value;
			}
		}

		public string RemarksB
		{
			get
			{
				return remarksB;
			}
			set	
			{
				remarksB = value;
			}
		}

		public string RemarksC
		{
			get
			{
				return remarksC;
			}
			set	
			{
				remarksC = value;
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

		public string RemarksD
		{
			get
			{
				return remarksD;
			}
			set	
			{
				remarksD = value;
			}
		}

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
			}
		}

		public float? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
			}
		}
	}
}
