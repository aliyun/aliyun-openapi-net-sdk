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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeDomainVerifyInfoResponse : AcsResponse
	{

		private string requestId;

		private string type;

		private string checkName;

		private string checkValue;

		private string modifiedTime;

		private string checkType;

		private string checkName1;

		private string checkName2;

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

		public string CheckName
		{
			get
			{
				return checkName;
			}
			set	
			{
				checkName = value;
			}
		}

		public string CheckValue
		{
			get
			{
				return checkValue;
			}
			set	
			{
				checkValue = value;
			}
		}

		public string ModifiedTime
		{
			get
			{
				return modifiedTime;
			}
			set	
			{
				modifiedTime = value;
			}
		}

		public string CheckType
		{
			get
			{
				return checkType;
			}
			set	
			{
				checkType = value;
			}
		}

		public string CheckName1
		{
			get
			{
				return checkName1;
			}
			set	
			{
				checkName1 = value;
			}
		}

		public string CheckName2
		{
			get
			{
				return checkName2;
			}
			set	
			{
				checkName2 = value;
			}
		}
	}
}
