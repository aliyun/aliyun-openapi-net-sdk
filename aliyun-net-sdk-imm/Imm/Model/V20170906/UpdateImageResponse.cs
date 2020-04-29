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
	public class UpdateImageResponse : AcsResponse
	{

		private string requestId;

		private string setId;

		private string imageUri;

		private string remarksA;

		private string remarksB;

		private string createTime;

		private string modifyTime;

		private string remarksC;

		private string remarksD;

		private string externalId;

		private string remarksArrayA;

		private string remarksArrayB;

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

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
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

		public string RemarksArrayA
		{
			get
			{
				return remarksArrayA;
			}
			set	
			{
				remarksArrayA = value;
			}
		}

		public string RemarksArrayB
		{
			get
			{
				return remarksArrayB;
			}
			set	
			{
				remarksArrayB = value;
			}
		}
	}
}
