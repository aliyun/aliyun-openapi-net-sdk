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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetCopyrightNoticeResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string applyPeople;

		private string modifyInfo;

		private string flowNumber;

		private string agentPeople;

		private string name;

		private string owner;

		private string createDate;

		private string admissibleNumber;

		private string fileList;

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

		public string ApplyPeople
		{
			get
			{
				return applyPeople;
			}
			set	
			{
				applyPeople = value;
			}
		}

		public string ModifyInfo
		{
			get
			{
				return modifyInfo;
			}
			set	
			{
				modifyInfo = value;
			}
		}

		public string FlowNumber
		{
			get
			{
				return flowNumber;
			}
			set	
			{
				flowNumber = value;
			}
		}

		public string AgentPeople
		{
			get
			{
				return agentPeople;
			}
			set	
			{
				agentPeople = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string Owner
		{
			get
			{
				return owner;
			}
			set	
			{
				owner = value;
			}
		}

		public string CreateDate
		{
			get
			{
				return createDate;
			}
			set	
			{
				createDate = value;
			}
		}

		public string AdmissibleNumber
		{
			get
			{
				return admissibleNumber;
			}
			set	
			{
				admissibleNumber = value;
			}
		}

		public string FileList
		{
			get
			{
				return fileList;
			}
			set	
			{
				fileList = value;
			}
		}
	}
}
