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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class GetScoreInfoResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private List<GetScoreInfo_ScorePo> data;

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

		public List<GetScoreInfo_ScorePo> Data
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

		public class GetScoreInfo_ScorePo
		{

			private int? scoreId;

			private string scoreName;

			private List<GetScoreInfo_ScoreParam> scoreInfos;

			public int? ScoreId
			{
				get
				{
					return scoreId;
				}
				set	
				{
					scoreId = value;
				}
			}

			public string ScoreName
			{
				get
				{
					return scoreName;
				}
				set	
				{
					scoreName = value;
				}
			}

			public List<GetScoreInfo_ScoreParam> ScoreInfos
			{
				get
				{
					return scoreInfos;
				}
				set	
				{
					scoreInfos = value;
				}
			}

			public class GetScoreInfo_ScoreParam
			{

				private string scoreSubName;

				private int? scoreNum;

				private int? scoreSubId;

				private int? scoreType;

				public string ScoreSubName
				{
					get
					{
						return scoreSubName;
					}
					set	
					{
						scoreSubName = value;
					}
				}

				public int? ScoreNum
				{
					get
					{
						return scoreNum;
					}
					set	
					{
						scoreNum = value;
					}
				}

				public int? ScoreSubId
				{
					get
					{
						return scoreSubId;
					}
					set	
					{
						scoreSubId = value;
					}
				}

				public int? ScoreType
				{
					get
					{
						return scoreType;
					}
					set	
					{
						scoreType = value;
					}
				}
			}
		}
	}
}
