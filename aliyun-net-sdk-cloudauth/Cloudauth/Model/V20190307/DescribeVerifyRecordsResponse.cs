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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class DescribeVerifyRecordsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? currentPage;

		private string queryId;

		private List<DescribeVerifyRecords_Records> recordsList;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public string QueryId
		{
			get
			{
				return queryId;
			}
			set	
			{
				queryId = value;
			}
		}

		public List<DescribeVerifyRecords_Records> RecordsList
		{
			get
			{
				return recordsList;
			}
			set	
			{
				recordsList = value;
			}
		}

		public class DescribeVerifyRecords_Records
		{

			private string bizType;

			private string bizId;

			private string dataStats;

			private string verifyId;

			private long? finishTime;

			private int? status;

			private float? idCardFaceComparisonScore;

			private float? authorityComparisonScore;

			private DescribeVerifyRecords_Material material;

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string DataStats
			{
				get
				{
					return dataStats;
				}
				set	
				{
					dataStats = value;
				}
			}

			public string VerifyId
			{
				get
				{
					return verifyId;
				}
				set	
				{
					verifyId = value;
				}
			}

			public long? FinishTime
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

			public float? IdCardFaceComparisonScore
			{
				get
				{
					return idCardFaceComparisonScore;
				}
				set	
				{
					idCardFaceComparisonScore = value;
				}
			}

			public float? AuthorityComparisonScore
			{
				get
				{
					return authorityComparisonScore;
				}
				set	
				{
					authorityComparisonScore = value;
				}
			}

			public DescribeVerifyRecords_Material Material
			{
				get
				{
					return material;
				}
				set	
				{
					material = value;
				}
			}

			public class DescribeVerifyRecords_Material
			{

				private string faceImageUrl;

				private string idCardName;

				private string idCardNumber;

				private DescribeVerifyRecords_IdCardInfo idCardInfo;

				public string FaceImageUrl
				{
					get
					{
						return faceImageUrl;
					}
					set	
					{
						faceImageUrl = value;
					}
				}

				public string IdCardName
				{
					get
					{
						return idCardName;
					}
					set	
					{
						idCardName = value;
					}
				}

				public string IdCardNumber
				{
					get
					{
						return idCardNumber;
					}
					set	
					{
						idCardNumber = value;
					}
				}

				public DescribeVerifyRecords_IdCardInfo IdCardInfo
				{
					get
					{
						return idCardInfo;
					}
					set	
					{
						idCardInfo = value;
					}
				}

				public class DescribeVerifyRecords_IdCardInfo
				{

					private string frontImageUrl;

					private string backImageUrl;

					private string name;

					private string number;

					private string address;

					private string birth;

					private string sex;

					private string nationality;

					private string authority;

					private string startDate;

					private string endDate;

					public string FrontImageUrl
					{
						get
						{
							return frontImageUrl;
						}
						set	
						{
							frontImageUrl = value;
						}
					}

					public string BackImageUrl
					{
						get
						{
							return backImageUrl;
						}
						set	
						{
							backImageUrl = value;
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

					public string Number
					{
						get
						{
							return number;
						}
						set	
						{
							number = value;
						}
					}

					public string Address
					{
						get
						{
							return address;
						}
						set	
						{
							address = value;
						}
					}

					public string Birth
					{
						get
						{
							return birth;
						}
						set	
						{
							birth = value;
						}
					}

					public string Sex
					{
						get
						{
							return sex;
						}
						set	
						{
							sex = value;
						}
					}

					public string Nationality
					{
						get
						{
							return nationality;
						}
						set	
						{
							nationality = value;
						}
					}

					public string Authority
					{
						get
						{
							return authority;
						}
						set	
						{
							authority = value;
						}
					}

					public string StartDate
					{
						get
						{
							return startDate;
						}
						set	
						{
							startDate = value;
						}
					}

					public string EndDate
					{
						get
						{
							return endDate;
						}
						set	
						{
							endDate = value;
						}
					}
				}
			}
		}
	}
}
