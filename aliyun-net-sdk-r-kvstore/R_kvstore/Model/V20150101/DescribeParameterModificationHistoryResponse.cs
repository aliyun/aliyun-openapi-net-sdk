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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeParameterModificationHistoryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeParameterModificationHistory_HistoricalParameter> historicalParameters;

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

		public List<DescribeParameterModificationHistory_HistoricalParameter> HistoricalParameters
		{
			get
			{
				return historicalParameters;
			}
			set	
			{
				historicalParameters = value;
			}
		}

		public class DescribeParameterModificationHistory_HistoricalParameter
		{

			private string parameterName;

			private string modifyTime;

			private string oldParameterValue;

			private string newParameterValue;

			public string ParameterName
			{
				get
				{
					return parameterName;
				}
				set	
				{
					parameterName = value;
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

			public string OldParameterValue
			{
				get
				{
					return oldParameterValue;
				}
				set	
				{
					oldParameterValue = value;
				}
			}

			public string NewParameterValue
			{
				get
				{
					return newParameterValue;
				}
				set	
				{
					newParameterValue = value;
				}
			}
		}
	}
}