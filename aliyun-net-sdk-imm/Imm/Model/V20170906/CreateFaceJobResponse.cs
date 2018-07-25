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
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class CreateFaceJobResponse : AcsResponse
	{

		private string requestId;

		private string jobId;

		private string setId;

		private string srcUri;

		private int? percent;

		private string createTime;

		private string finishTime;

		private string status;

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
	}
}