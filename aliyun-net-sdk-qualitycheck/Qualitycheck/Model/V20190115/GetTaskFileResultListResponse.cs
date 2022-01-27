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
	public class GetTaskFileResultListResponse : AcsResponse
	{

		private int? dataSize;

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? pageSize;

		private int? totalCount;

		private List<GetTaskFileResultList_TaskResultReviewInfo> data;

		public int? DataSize
		{
			get
			{
				return dataSize;
			}
			set	
			{
				dataSize = value;
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<GetTaskFileResultList_TaskResultReviewInfo> Data
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

		public class GetTaskFileResultList_TaskResultReviewInfo
		{

			private int? status;

			private int? dataType;

			private int? hitNumber;

			private bool? hitRule;

			private string nextVid;

			private string preVid;

			private float? reviewAccuracyRate;

			private int? realViolationNumber;

			private bool? isHitRule;

			private string fileName;

			private int? totalScore;

			private int? checkNumber;

			private string fileMergeName;

			private string bucketName;

			private bool? handTaskFile;

			private string taskId;

			private string vid;

			private List<string> hitRuleSet;

			public int? Status
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

			public int? DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
				}
			}

			public int? HitNumber
			{
				get
				{
					return hitNumber;
				}
				set	
				{
					hitNumber = value;
				}
			}

			public bool? HitRule
			{
				get
				{
					return hitRule;
				}
				set	
				{
					hitRule = value;
				}
			}

			public string NextVid
			{
				get
				{
					return nextVid;
				}
				set	
				{
					nextVid = value;
				}
			}

			public string PreVid
			{
				get
				{
					return preVid;
				}
				set	
				{
					preVid = value;
				}
			}

			public float? ReviewAccuracyRate
			{
				get
				{
					return reviewAccuracyRate;
				}
				set	
				{
					reviewAccuracyRate = value;
				}
			}

			public int? RealViolationNumber
			{
				get
				{
					return realViolationNumber;
				}
				set	
				{
					realViolationNumber = value;
				}
			}

			public bool? IsHitRule
			{
				get
				{
					return isHitRule;
				}
				set	
				{
					isHitRule = value;
				}
			}

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

			public int? TotalScore
			{
				get
				{
					return totalScore;
				}
				set	
				{
					totalScore = value;
				}
			}

			public int? CheckNumber
			{
				get
				{
					return checkNumber;
				}
				set	
				{
					checkNumber = value;
				}
			}

			public string FileMergeName
			{
				get
				{
					return fileMergeName;
				}
				set	
				{
					fileMergeName = value;
				}
			}

			public string BucketName
			{
				get
				{
					return bucketName;
				}
				set	
				{
					bucketName = value;
				}
			}

			public bool? HandTaskFile
			{
				get
				{
					return handTaskFile;
				}
				set	
				{
					handTaskFile = value;
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

			public string Vid
			{
				get
				{
					return vid;
				}
				set	
				{
					vid = value;
				}
			}

			public List<string> HitRuleSet
			{
				get
				{
					return hitRuleSet;
				}
				set	
				{
					hitRuleSet = value;
				}
			}
		}
	}
}
